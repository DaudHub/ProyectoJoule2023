using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiAlmacenes.Models;
using MySqlConnector;
using ApiAlmacenes;
using Microsoft.VisualBasic;
using System.Data;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace ApiAlmacenes.Controllers;

[ApiController]
public class MyController : Controller {

    public MySqlConnection db_conn = new ("Server=127.0.0.1;User ID=apialmacen;Password=urbgieubgiutg98rtygtgiurnindg8958y;Database=proyecto");

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
            command.CommandText = @$"insert into proyecto.paquete (idpaquete, comentarios, pesokg, volumen, usuario)
                values ({arg.Element.ID},'{arg.Element.Comments}', {arg.Element.Weight_Kg}, {arg.Element.Volume_m3}, {arg.Element.User})";
            command.ExecuteNonQuery();
            foreach (var characteristic in arg.Element.Characteristics) {
                command.CommandText = $"insert into proyecto.caracteristicaspaquete values ('{arg.Element.ID}','{characteristic}')";
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
            Package package = new ();
            command.CommandText= $@"select * from caracteristicaspaquete where idpaquete={arg.Element}";
            var reader = command.ExecuteReader();
            while (reader.Read()){
                for (int i = 0; i < reader.FieldCount; i++) {
                    package.Characteristics.Add(reader.GetString(i));
                }
            }
            reader.Close();
            command.CommandText = $@"select comentarios, pesokg, volumen, usuario from paquete where idpaquete={arg.Element}";
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
            return package;
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
            command.CommandText = @$"insert into lote (idlote, idlugarenvio)
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
    [Route("assignpackage")]
    public dynamic AssignPackage([FromBody] VerifTriangle<Bundle,Package> arg) {
        try {
            db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            command.CommandText = @$"insert into paquetelote values ({arg.Element1.ID},{arg.Element2.ID})";
            command.ExecuteNonQuery();
            return new {
                success = true,
                message = $"package {arg.Element2.ID} successfully assigned to bundle {arg.Element1.ID}"
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
    public dynamic LoadBundle(VerifCouple<Load> arg) {
        try{
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into cargalote
                values ({arg.Element.Bundle}, '{arg.Element.Plate}', '{arg.Element.User}','{arg.Element.Departure_Date}')";
            command.ExecuteNonQuery();
            return new {
                success = true,
                message = "bundle loaded successfully"
            };
        }
        catch(Exception e) {
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

    private bool VerifyCredentials(Verification ver) {
        try {
            if (db_conn.State == ConnectionState.Closed) 
                db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
            @$"select proyecto.usuarios.usuario, rol 
            from proyecto.usuarios inner join proyecto.tokens on proyecto.usuarios.usuario=proyecto.tokens.usuario 
            where token='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetString(1) != "almacenero" && reader.GetString(1) != "admin") return false;
            }
            reader.Close();
            return true;
        }
        catch(Exception) {
            throw;
        }
    }
}