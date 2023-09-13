using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiTransito.Models;
using ApiAlmacenes;
using MySqlConnector;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ApiAlmacenes.Controllers;

[ApiController]
public class MyController : Controller {
    
    public MySqlConnection db_conn = new ("Server=127.0.0.1;User ID=transito;Password=gbiugbiuerbgieurgbiuerbgiubre;");
    
    [HttpPost]
    [Route("viewbundles")]
    public dynamic ViewBundles([FromBody] Verification auth) {
        try {
            db_conn.Open();
            if(!VerifyCredentialsForTruckDriver(auth)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = @$"select matricula, fechasalida from proyecto.conduce where usuario='{auth.User}' order by fechasalida desc limit 1";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return new {
                success = false,
                message = "the user is not driving a truck"
            };
            reader.Read();
            string plate = reader.GetString(0);
            var truckDepartureDate = reader.GetDateTime(1).ToString("yyyy-MM-dd");
            reader.Close();
            command.CommandText = @$"select cargalote.idlote, idlugarenvio from proyecto.cargalote
                                    inner join proyecto.lote on cargalote.idlote=lote.idlote
                                    where matricula='{plate}' and usuario='{auth.User}' and fechasalida='{truckDepartureDate}'";
            reader = command.ExecuteReader();
            var bundlesInTruck = new List<Bundle>();
            while (reader.Read()) {
                bundlesInTruck.Add(new Bundle(reader.GetInt32(0), reader.GetInt32(1)));
            }
            reader.Close();
            return new {
                success = true,
                message = "bundles in truck retrieved successfully",
                bundles = bundlesInTruck.ToArray()
            };
        }
        catch (Exception ex) {
            return new {
                success = false,
                message = "error while retrieving bundles",
                exception = ex.ToString() + ex.Message
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("mypackages")]
    public dynamic SeePackages([FromBody] Verification auth) {
        try {
            db_conn.Open();
            if (!VerifyCredentialsForOthers(auth)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = @$"select paquete.usuario, paquete.idpaquete, loteenvio.idestado, lotepaquete.idlote, cargalote.matricula, cargalote.usuario, loteenvio.fechaestimada
                                    from proyecto.paquete
                                        inner join proyecto.lotepaquete on paquete.idpaquete=lotepaquete.idpaquete
                                        left join proyecto.cargalote on lotepaquete.idlote=cargalote.idlote
                                        left join proyecto.loteenvio on lotepaquete.idlote=loteenvio.idlote
                                    where paquete.usuario='{auth.User}'";
            var reader = command.ExecuteReader();
            var packages = new List<dynamic>();
            while (reader.Read()) {
                packages.Add(new {ID = reader.GetInt32(0), comments = reader.GetString(1), weight = reader.GetInt32(2), volume = reader.GetInt32(3), state = reader.GetString(4)});
            }
            reader.Close();
            return new {
                success = true,
                message = "packages retrieved successfully",
                packages = packages.ToArray()
            };
        }
        catch (Exception e) {
            return new {
                success = false,
                message = "error while retrieving packages",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }
    
    [HttpPost]
    [Route("route")]
    public dynamic CalculateRoute([FromBody] Verification auth, float coordinateX, float coordinateY) {
        try {
            db_conn.Open();
            if(!VerifyCredentialsForTruckDriver(auth)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = @$"select matricula, fechasalida from proyecto.conduce where usuario='{auth.User}' order by fechasalida desc limit 1";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return new {
                success = false,
                message = "the user is not driving a truck"
            };
            reader.Read();
            string plate = reader.GetString(0);
            var truckDepartureDate = reader.GetDateTime(1).ToString("yyyy-MM-dd");
            reader.Close();
            var command2 = new MySqlCommand(null, db_conn);
            command2.CommandText = @$"select proyecto.lugarenvio.latitud, proyecto.lugarenvio.longitud 
                                    from proyecto.cargalote
                                        inner join proyecto.loteenvio on cargalote.idlote=loteenvio.idlote
                                        inner join proyecto.lugarenvio on proyecto.loteenvio.idlugarenvio=proyecto.lugarenvio.idlugarenvio
                                    where matricula='{plate}' and usuario='{auth.User}' and fechasalida='{truckDepartureDate}'";
            reader = command2.ExecuteReader();
            var coordinates = new List<(float, float)>();
            while (reader.Read()) {
                coordinates.Add((reader.GetFloat(0), reader.GetFloat(1)));
            }
            reader.Close();
            var orderedCoordinates = new List<(float, float)>();
            Routes.MostEfficientRoute(coordinates, (coordinateX, coordinateY), ref orderedCoordinates);
            var orderedCoordinateArray = new dynamic[orderedCoordinates.Count];
            for (int i = 0; i < orderedCoordinates.Count; i++) orderedCoordinateArray[i] = new {
                coordinateX = orderedCoordinates[i].Item1,
                coordinateY = orderedCoordinates[i].Item2
            };
            return new {
                success = true,
                message = "route calculated successfully",
                route = orderedCoordinateArray
            };
        }
        catch (Exception e) {
            return new {
                success = false,
                message = "error while calculating route",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("confirm")]
    public dynamic ConfirmPackage(Verification auth) {
        try {
            db_conn.Open();
            if(!VerifyCredentialsForTruckDriver(auth)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = @$"select matricula, fechasalida from proyecto.conduce where usuario='{auth.User}' order by fechasalida desc limit 1";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return new {
                success = false,
                message = "the user is not driving a truck"
            };
            return new {
                success = true,
                message = "delivery confirmed successfully"
            };
        }
        catch (Exception e) {
            return new {
                success = false,
                message = "error while confirming delivery",
                exception = e.ToString()
            };
        }
        finally {

        }
    }

    private bool VerifyCredentialsForTruckDriver(Verification ver) {
        try {
            if (db_conn.State == ConnectionState.Closed) 
                db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
                @$"select proyecto.usuario.usuario, proyecto.usuario.idrol 
                from proyecto.usuario inner join proyecto.tokens on proyecto.usuario.usuario=proyecto.tokens.usuario 
                where tokn='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetInt32(1) != 1 && reader.GetInt32(1) != 3) return false;
            }
            reader.Close();
            return true;
        }
        catch(Exception) {
            throw;
        }
    }

    private bool VerifyCredentialsForOthers(Verification ver) {
        try {
            if (db_conn.State == ConnectionState.Closed) 
                db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
                @$"select proyecto.usuario.usuario, proyecto.usuario.idrol 
                from proyecto.usuario inner join proyecto.tokens on proyecto.usuario.usuario=proyecto.tokens.usuario 
                where tokn='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetInt32(1) != 1 && reader.GetInt32(1) != 3 && reader.GetInt32(1) != 4) return false;
            }
            reader.Close();
            return true;
        }
        catch(Exception) {
            throw;
        }
    }

}