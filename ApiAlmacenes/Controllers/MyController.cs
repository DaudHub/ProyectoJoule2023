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
    public dynamic CreateBundle(VerifCouple<Bundle> arg) {
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
    public dynamic AssignPackage(VerifTriangle<Package,Bundle> arg) {
        try {
            db_conn.Open();
            return new {
                success = true,
                message = "package {} successfully assigned to bundle {}"
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
            @$"select sys.sysusers.username, rol 
            from sys.sysusers inner join sys.tokens on sys.sysusers.username=sys.tokens.username 
            where token='{ver.Token}' and passwd='{MyEncryption.EncryptToString(ver.Password)}'";
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