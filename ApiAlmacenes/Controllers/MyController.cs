using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiAlmacenes.Models;
using MySqlConnector;
using ApiAlmacenes;
using Microsoft.VisualBasic;

namespace ApiAlmacenes.Controllers;

[ApiController]
public class MyController : Controller {

    public MySqlConnection db_conn = new ("Server=127.0.0.1;User ID=adminAlmacen;Password=urbgieubgiutg98rtygtgiurnindg8958y");

    [HttpPost]
    [Route("newpackage")]
    public dynamic CreatePackage([FromBody] VerifCouple<Package> arg) {
        try {
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                message = "verification error"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into sys.paquete (comentarios, pesokg, volumen, ci, precio) 
            values ('{arg.Element.Comments}', '{arg.Element.Weight_Kg}', '{arg.Element.Volume_m3}', '{arg.Element.Customer}', '{arg.Element.Price}')";
            command.ExecuteNonQuery();
            foreach (var item in arg.Element.Characteristics) {
                command.CommandText = $"select nombre from caracteristicas";
                var reader = command.ExecuteReader();
                while (reader.Read())
                    if (reader.GetString(0) == item)
                        arg.Element.Characteristics.Add(item);
                reader.Close();
                command.CommandText = $"insert into sys.caracteristicaspaquete values ('{arg.Element.Customer}','{item}')";
                command.ExecuteNonQuery();
            }
            return new {
                success = true,
                message = "package created successfully"
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
    [Route("newbundle")]
    public dynamic CreateBundle([FromBody] VerifCouple<Bundle> arg) {
        try{
            db_conn.Open();
            if (!VerifyCredentials(arg.Credentials)) return new {
                success = false,
                mesage = "authentication error"
            };
            MySqlCommand command = new (null, db_conn);
            command.CommandText = @$"insert into lote (idlugarenvio, estado, fechaestimada) 
                values ('{arg.Element.Deposit}', '{arg.Element.State}')";
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
                message = "verification error"
            };
            command.CommandText = @$"insert into paquetelote values ({arg.Element1.ID},{arg.Element2.ID})";
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

    private bool VerifyCredentials(Verification ver) {
        try {
            db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
            @$"select proyecto.usuarios.usuario, rol 
            from sys.sysusers inner join proyecto.tokens on proyecto.usuarios.usuario=proyecto.tokens.usuario 
            where token='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            if (reader.Read() && reader.GetString(1) != "almacenero") return false;
            reader.Close();
            return true;
        }
        catch(Exception) {
            return false;
        }
        finally {
            db_conn.Close();
        }
    }
}