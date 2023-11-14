using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiAlmacenes.Models;
using MySqlConnector;
using ApiAlmacenes;
using Microsoft.VisualBasic;
using System.Data;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Linq.Expressions;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.ObjectPool;

namespace ApiAlmacenes.Controllers;

[ApiController]
public class MyController : Controller {

    public MySqlConnection db_conn = new ("Server=127.0.0.1;User ID=apialmacen;Password=urbgieubgiutg98rtygtgiurnindg8958y");

    [HttpPost]
    [Route("newpackage")]
    public dynamic CreatePackage([FromBody] VerifCouple<Package> arg) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into proyecto.paquete (idpaquete, comentarios, pesokg, volumenm3, usuario, idestadofisico, usuarioestado)
                values ({arg.Element.ID},'{arg.Element.Comments}', {arg.Element.Weight_Kg}, {arg.Element.Volume_m3}, '{arg.Element.User}', '{arg.Element.PhysicalState}', '{arg.Element.StateUser}')";
            command.ExecuteNonQuery();
            foreach (var characteristic in arg.Element.Characteristics) {
                command.CommandText = $"insert into proyecto.paquetecaracteristicas values ('{arg.Element.ID}', '{characteristic}')";
                command.ExecuteNonQuery();
            }
            return new {
                success = true,
                message = "package created successfully",
            };
        }
        catch (Exception e) {
            return new {
                success = false,
                message = "error while creating package",
                exception = e.ToString()
            };
        } finally {
            db_conn.Close();
        }
    }
    
    [HttpPost]
    [Route("getpackage")]
    public dynamic GetPackageByID([FromBody] VerifCouple<int> arg) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            var characteristics = new List<string>();
            command.CommandText= $@"select caracteristicas.nombre from proyecto.paquetecaracteristicas
                                        inner join proyecto.caracteristicas
                                            on caracteristicas.idcaracteristica=paquetecaracteristicas.idcaracteristica
                                    where idpaquete={arg.Element}";
            var reader = command.ExecuteReader();
            while (reader.Read()){
                characteristics.Add(reader.GetString(0));
            }
            reader.Close();
            command.CommandText = $@"select comentarios, pesokg, volumenm3, paquete.usuario, nombreestadofisico, usuarioestado 
                                    from proyecto.paquete
                                        inner join proyecto.estadofisico
                                            on paquete.idestadofisico=estadofisico.idestadofisico
                                        inner join proyecto.lotepaquete 
                                            on paquete.idpaquete=lotepaquete.idpaquete
                                        inner join proyecto.lote 
                                            on lotepaquete.idlote=lote.idlote
                                        inner join proyecto.almacenero on lote.idlugarenvio=almacenero.idlugarenvio
                                    where paquete.idpaquete={arg.Element} and almacenero.usuario='{arg.Credentials.User}'";
            reader = command.ExecuteReader();
            reader.Read();
            if (!reader.HasRows) return new {
                success = false,
                message = "non-existing package"
            };
            var package = new {
                id = arg.Element,
                comments = reader.GetString(0),
                weight_Kg = reader.GetDecimal(1),
                volume_m3 = reader.GetDecimal(2),
                user = reader.GetString(3),
                physicalState = reader.GetString(4),
                stateUser = reader.GetString(5),
                characteristics = characteristics
            };
            return new {
                success = true,
                package = package
            };
        }
        catch (Exception e) {
            return new {
                success = false,
                message = "error while retrieving package",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("packages")]
    public dynamic GetAllPackages(Verification auth) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(auth)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = $@"select paquete.idpaquete, paquete.comentarios, paquete.pesokg, paquete.volumenm3, paquete.usuario, estadofisico.nombreestadofisico, paquete.usuarioestado
                        from proyecto.paquete
                            inner join proyecto.lotepaquete
                                on paquete.idpaquete=lotepaquete.idpaquete
                            inner join proyecto.lote
                                on lotepaquete.idlote=lote.idlote
                            inner join proyecto.lugarenvio
                                on lote.idlugarenvio=lugarenvio.idlugarenvio
                            inner join proyecto.estadofisico on paquete.idestadofisico=estadofisico.idestadofisico
                        where lote.idlugarenvio=(select idlugarenvio from proyecto.almacenero where almacenero.usuario='{auth.User}')";
            var reader = command.ExecuteReader();
            var packages = new List<dynamic>();
            List<string> characteristics;
            MySqlDataReader reader2;
            using (var db_conn2 = new MySqlConnection("Server=127.0.0.1;User ID=apialmacen;Password=urbgieubgiutg98rtygtgiurnindg8958y")) {
                db_conn2.Open();
                var command2 = new MySqlCommand(null, db_conn2);
                while (reader.Read()) {
                    characteristics = new List<string>();
                    command2.CommandText = @$"select caracteristicas.nombre
                                            from proyecto.paquetecaracteristicas
                                                inner join proyecto.caracteristicas
                                                    on paquetecaracteristicas.idcaracteristica=caracteristicas.idcaracteristica
                                            where paquetecaracteristicas.idpaquete={reader.GetInt32(0)}";
                    reader2 = command2.ExecuteReader();
                    while (reader2.Read()) {
                        characteristics.Add(reader2.GetString(0));
                    }
                    reader2.Close();
                    packages.Add(new {
                        ID = reader.GetInt32(0),
                        Comments = reader.GetString(1),
                        Weight_Kg = reader.GetDecimal(2),
                        Volume_m3 = reader.GetDecimal(3),
                        User = reader.GetString(4),
                        PhysicalState = reader.GetString(5),
                        StateUser = reader.GetString(6),
                        Characteristics = characteristics
                    });
                }
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
    [Route("newbundle")]
    public dynamic CreateBundle([FromBody] VerifCouple<int> arg) {
        try{
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                mesage = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into proyecto.lote (idlote, idlugarenvio)
                values ({arg.Element}, (select idlugarenvio from proyecto.almacenero where usuario='{arg.Credentials.User}'))";
            command.ExecuteNonQuery();
            return new {
                success = true,
                message = "bundle created successfully"
            };
        }
        catch(Exception e){
            return new {
                success = false,
                message = "error while creating bundle",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("bundles")]
    public dynamic GetBundles(Verification ver) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(ver)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = $@"select lote.* 
                                    from proyecto.lote
                                        inner join proyecto.almacenero
                                            on lote.idlugarenvio=almacenero.idlugarenvio
                                    where almacenero.usuario='{ver.User}'";
            var reader = command.ExecuteReader();
            var bundles = new List<dynamic>();
            while (reader.Read()) {
                bundles.Add(new {bundleID = reader.GetInt32(0), depositID = reader.GetInt32(1)});
            }
            return new {
                success = true,
                message = "bundles retrieved successfully",
                bundles = bundles
            };
        }
        catch (Exception ex) {
            return new {
                success = false,
                message = "exception while retrieving bundles",
                exeption = ex.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("packagesinbundle")]
    public dynamic GetPackagesInBundle(VerifCouple<int> arg) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = $@"select paquete.idpaquete, paquete.comentarios, paquete.pesokg, paquete.volumenm3, paquete.usuario, estadofisico.nombreestadofisico, paquete.usuarioestado
                        from proyecto.paquete
                            inner join proyecto.lotepaquete
                                on paquete.idpaquete=lotepaquete.idpaquete
                            inner join proyecto.lote
                                on lotepaquete.idlote=lote.idlote
                            inner join proyecto.lugarenvio
                                on lote.idlugarenvio=lugarenvio.idlugarenvio
                            inner join proyecto.estadofisico on paquete.idestadofisico=estadofisico.idestadofisico
                        where lote.idlugarenvio=(select idlugarenvio from proyecto.almacenero where almacenero.usuario='{arg.Credentials.User}') and lote.idlote={arg.Element}";
            var reader = command.ExecuteReader();
            var packages = new List<dynamic>();
            List<string> characteristics;
            MySqlDataReader reader2;
            using (var db_conn2 = new MySqlConnection("Server=127.0.0.1;User ID=apialmacen;Password=urbgieubgiutg98rtygtgiurnindg8958y")) {
                db_conn2.Open();
                var command2 = new MySqlCommand(null, db_conn2);
                while (reader.Read()) {
                    characteristics = new List<string>();
                    command2.CommandText = @$"select caracteristicas.nombre
                                            from proyecto.paquetecaracteristicas
                                                inner join proyecto.caracteristicas
                                                    on paquetecaracteristicas.idcaracteristica=caracteristicas.idcaracteristica
                                            where paquetecaracteristicas.idpaquete={reader.GetInt32(0)}";
                    reader2 = command2.ExecuteReader();
                    while (reader2.Read()) {
                        characteristics.Add(reader2.GetString(0));
                    }
                    reader2.Close();
                    packages.Add(new {
                        ID = reader.GetInt32(0),
                        Comments = reader.GetString(1),
                        Weight_Kg = reader.GetDecimal(2),
                        Volume_m3 = reader.GetDecimal(3),
                        User = reader.GetString(4),
                        PhysicalState = reader.GetString(5),
                        StateUser = reader.GetString(6),
                        Characteristics = characteristics
                    });
                }
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
    [Route("checkin")]
    public dynamic CheckInBundle(VerifCouple<CheckIn> arg) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = $"update proyecto.lote set idlugarenvio={arg.Element.DepositID} where idlote={arg.Element.BundleID}";
            command.ExecuteNonQuery();
            return new {
                success = true,
                message = "bundle checked in successfully"
            };
        }
        catch (Exception e) {
            return new {
                success = false,
                message = "error while checking in bundle",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("assignpackage")]
    public dynamic AssignPackage([FromBody] VerifCouple<BundlePackage> arg) {
        try {
            db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            if (!IsBundleInDepot(arg.Credentials.User, arg.Element.BundleID)) return new {
                success = false,
                message = "permission denied (bundle is not in the depot associated to this user)"
            };
            command.CommandText = @$"insert into proyecto.lotepaquete values ({arg.Element.BundleID},{arg.Element.PackageID})";
            command.ExecuteNonQuery();
            return new {
                success = true,
                message = $"package {arg.Element.PackageID} successfully assigned to bundle {arg.Element.BundleID}"
            };
        }
        catch(Exception e) {
            return new {
                success = false,
                message = "error while assigning package",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }


    [HttpPost]
    [Route("loadbundle")]
    public dynamic LoadBundle([FromBody] VerifCouple<Load> arg) {
        try{
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            if (!IsBundleInDepot(arg.Credentials.User, arg.Element.Bundle)) return new {
                success = false,
                message = "permission denied (bundle is not in the depot associated to this user)"
            };
            if(!HasDestination(arg.Element.Bundle)) return new {
                success = false,
                message = "permission denied (bundle has no destination assigned)"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into proyecto.cargalote
                values ({arg.Element.Bundle}, '{arg.Element.User}', '{arg.Element.Plate}', (select fechasalida from proyecto.conduce where usuario='{arg.Element.User}' and matricula='{arg.Element.Plate}' limit 1))";
            command.ExecuteNonQuery();
            return new {
                success = true,
                message = "bundle loaded successfully"
            };
        }
        catch (Exception e) {
            return new {
                success = false,
                message = "failed to load bundle",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("sendbundle")]
    public dynamic SendBundle([FromBody] VerifCouple<Shipment> arg) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            if (IsBundleInDepot(arg.Credentials.User, arg.Element.BundleID)) return new {
                success = false,
                message = "permission denied (bundle is not in the depot associated to this user)"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = @$"insert into proyecto.loteenvio values ({arg.Element.BundleID}, '{arg.Element.Destination}', '{arg.Element.EstimatedDate}', {arg.Element.StateID})";
            return new {
                success=true,
                message="bundle due sending"
            };
        }
        catch(Exception e) {
            return new {
                success = false,
                message = "error while obtaining places",
                exception = e.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    [HttpPost]
    [Route("places")]
    public dynamic GetPlaces(Verification ver) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(ver)) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = $@"select lugarenvio.idlugarenvio
                                    from proyecto.lugarenvio
                                        left join proyecto.almacenero
                                            on lugarenvio.idlugarenvio=almacenero.idlugarenvio
                                    where almacenero.usuario!='{ver.User}' or almacenero.usuario is null";
            var reader = command.ExecuteReader();
            var places = new List<int>();
            while (reader.Read()) {
                places.Add(reader.GetInt32(0));
            }
            return new {
                success = true,
                places = places
            };
        }
        catch (Exception ex) {
            return new {
                success = false,
                message = "error while obtaining places",
                exception = ex.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }

    private bool IsBundleInDepot(string DepotManager, int BundleID) {
        if (db_conn.State == ConnectionState.Closed)
            db_conn.Open();
        var command = new MySqlCommand(null, db_conn);
        command.CommandText = @$"select proyecto.almacenero.idlugarenvio
                                from proyecto.almacenero
                                    inner join proyecto.lote
                                        on almacenero.idlugarenvio=lote.idlugarenvio
                                where usuario='{DepotManager}' and lote.idlote={BundleID}";
        var reader = command.ExecuteReader();
        if (reader.Read()) {
            reader.Close();
            return true;
        }
        else {
            reader.Close();
            return false;
        } 
    }

    private bool HasDestination(int bundleID) {
        if (db_conn.State == ConnectionState.Closed)
            db_conn.Open();
        var command = new MySqlCommand(null, db_conn);
        command.CommandText = $"select proyecto.loteenvio.idlugarenvio from proyecto.loteenvio where idlote={bundleID}";
        var reader = command.ExecuteReader();
        if(!reader.HasRows) {
            reader.Close();
            return false;
        }
        else {
            reader.Close();
            return true;
        }
    }

    private bool VerifyCredentials(Verification ver) {
        try {
            if (db_conn.State == ConnectionState.Closed) 
                db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
            @$"select proyecto.usuario.usuario, proyecto.rol.nombre
                from proyecto.usuario inner join proyecto.tokens on proyecto.usuario.usuario=proyecto.tokens.usuario
                inner join proyecto.rol on proyecto.rol.idrol=proyecto.usuario.idrol
                where usuario.usuario='{ver.User}' and tokn='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetString(1) != "almacenero" && reader.GetString(1) != "administrador") return false;
            }
            reader.Close();
            return true;
        }
        catch(Exception) {
            throw;
        }
    }
}