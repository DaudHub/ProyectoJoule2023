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
    
    [HttpGet]
    [Route("getpackage")]
    public dynamic GetPackageByID([FromBody] VerifCouple<int> arg) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            var package = new Package();
            command.CommandText= $@"select * from proyecto.paquetecaracteristicas where idpaquete={arg.Element}";
            var reader = command.ExecuteReader();
            while (reader.Read()){
                for (int i = 0; i < reader.FieldCount; i++) {
                    package.Characteristics.Add(reader.GetString(i));
                }
            }
            reader.Close();
            command.CommandText = $@"select comentarios, pesokg, volumenm3, usuario, estadofisico, usuarioestado from proyecto.paquete where idpaquete={arg.Element}";
            reader = command.ExecuteReader();
            reader.Read();
            if (!reader.HasRows) return new {
                success = false,
                message = "non-existing package"
            };
            package.ID = arg.Element;
            package.Comments = reader.GetString(0);
            package.Weight_Kg = (decimal) reader.GetValue(1);
            package.Volume_m3 = (decimal) reader.GetValue(2);
            package.User = reader.GetString(3);
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
    [Route("newbundle")]
    public dynamic CreateBundle([FromBody] VerifCouple<Bundle> arg) {
        try{
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                mesage = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into proyecto.lote (idlote, idlugarenvio)
                values ({arg.Element.ID}, {arg.Element.Deposit})";
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
            if(!HasDestination(arg.Element.Bunele)) return new {
                success = false,
                message = "permission denied (bundle has no destination assigned)"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into proyecto.cargalote
                values ({arg.Element.Bundle}, '{arg.Element.User}', '{arg.Element.Plate}','{arg.Element.Departure_Date}')";
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
                message = "error",
                exception = e.ToString()
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
        command.CommandText = @$"select proyecto.almacenero.idlugarenvio from proyecto.almacenero where usuario='{DepotManager}'";
        var reader = command.ExecuteReader();
        reader.Read();
        int lugarenvio = (int) reader.GetValue(0);
        reader.Close();
        command.CommandText = @$"select proyecto.lote.idlugarenvio from proyecto.lote where idlote={BundleID}";
        reader = command.ExecuteReader();
        reader.Read();
        return ((int) reader.GetValue(0) == lugarenvio);
    }

    private bool HasDestination(int bundleID) {
        if (db_conn.State == ConnectionState.Closed)
            db_conn.Open();
        var command = new MySqlCommand(null, db_conn);
        command.CommandText = $"select proyecto.loteenvio.idlugarenvio from proyecto.loteenvio where idlote={bundleID}"
        var reader = command.ExecuteReader();
        if(!reader.HasRows) return false;
        else return true;
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
                where tokn='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
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