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
    public dynamic ViewBundles() {
        try {
            db_conn.Open();
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
                @$"select proyecto.usuarios.usuario, rol 
                from proyecto.usuarios inner join proyecto.tokens on proyecto.usuarios.usuario=proyecto.tokens.usuario 
                where token='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetString(1) != "camionero" && reader.GetString(1) != "admin") return false;
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
                @$"select proyecto.usuarios.usuario, rol 
                from proyecto.usuarios inner join proyecto.tokens on proyecto.usuarios.usuario=proyecto.tokens.usuario 
                where token='{ver.Token}' and pwd='{MyEncryption.EncryptToString(ver.Password)}'";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return false;
            while (reader.Read()) {
                if (reader.GetString(1) != "usuario" && reader.GetString(1) != "camionero" && reader.GetString(1) != "admin") return false;
            }
            reader.Close();
            return true;
        }
        catch(Exception) {
            throw;
        }
    }

}
