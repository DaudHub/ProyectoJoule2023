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
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
            @$"select sys.sysusers.username, rol 
            from sys.sysusers inner join sys.tokens on sys.sysusers.username=sys.tokens.username 
            where token='{arg.Credentials.Token}' and passwd='{MyEncryption.EncryptToString(arg.Credentials.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return new {
                success = false,
                message = "verification error"
            };
            if (reader.Read() && reader.GetString(1) != "almacenero") return new {
                success = false,
                message = "verification error"
            };
            reader.Close();
            command.CommandText = @$"insert into sys.paquete (comentarios, pesokg, volumen, ci) 
            values ('{arg.Element.Comments}', '{arg.Element.Weight_Kg}', '{arg.Element.Volume_m2}', '{arg.Element.Customer}')";
            command.ExecuteNonQuery();
            foreach (var item in arg.Element.Characteristics) {
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
}