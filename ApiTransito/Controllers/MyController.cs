using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiTransito.Models;
using ApiAlmacenes;
using MySqlConnector;
using System.Data;

namespace ApiAlmacenes.Controllers;

[ApiController]
public class MyController : Controller {
    
    public MySqlConnection db_conn = new ("Server=127.0.0.1;User ID=apialmacen;Password=urbgieubgiutg98rtygtgiurnindg8958y;Database=proyecto");
    
    [HttpGet]
    [Route("viewbundles")]
    public dynamic ViewBundles(string token, string username, string password) {
        try {
            db_conn.Open();
            if(VerifyCredentialsForTruckDriver(new Verification() { User = username, Password = password, Token = token })) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = @"select from ";
            return new {}; 
        }
        catch (Exception ex) {
            return new {
                message = "error while retrieving bundles",
                exception = ex.ToString()
            };
        }
        finally {
            db_conn.Close();
        }
    }
    private bool VerifyCredentialsForTruckDriver(Verification ver) {
        try {
            if (db_conn.State == ConnectionState.Closed) 
                db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
                @$"select proyecto.usuario.usuario, rol 
                from proyecto.usuarios inner join proyecto.tokens on proyecto.usuario.usuario=proyecto.tokens.usuario 
                where tokn='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetString(1) != "camionero" && reader.GetString(1) != "administrador") return false;
            }
            reader.Close();
            return true;
        }
        catch(Exception) {
            throw;
        }
    }

    private bool VerifyCredentialsForUser(Verification ver) {
        try {
            if (db_conn.State == ConnectionState.Closed) 
                db_conn.Open();
            MySqlCommand command = new (null, db_conn);
            command.CommandText = 
                @$"select proyecto.usuario.usuario, rol 
                from proyecto.cliente inner join proyecto.tokens on proyecto.usuario.usuario=proyecto.tokens.usuario 
                where tokn='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetString(1) != "usuario" && reader.GetString(1) != "camionero" && reader.GetString(1) != "administrador") return false;
            }
            reader.Close();
            return true;
        }
        catch(Exception) {
            throw;
        }
    }

}
