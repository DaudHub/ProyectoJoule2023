using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiTransito.Models;
using ApiAlmacenes;
using MySqlConnector;
using System.Data;

namespace ApiAlmacenes.Controllers;

[ApiController]
public class MyController : Controller {
    
    public MySqlConnection db_conn = new ("Server=127.0.0.1;User ID=transito;Password=gbiugbiuerbgieurgbiuerbgiubre;Database=proyecto;");
    
    [HttpGet]
    [Route("viewbundles")]
    public dynamic ViewBundles(string token, string username, string password) {
        try {
            db_conn.Open();
            if(!VerifyCredentialsForTruckDriver(new Verification() { User = username, Password = password, Token = token })) return new {
                success = false,
                message = "authentication error"
            };
            var command = new MySqlCommand(null, db_conn);
            command.CommandText = @$"select matricula, fechasalida from conduce where usuario='{username}' order by fechasalida desc limit 1";
            var reader = command.ExecuteReader();
            if (!reader.HasRows) return new {
                success = false,
                message = "the user is not driving a truck"
            };
            reader.Read();
            string plate = reader.GetString(0);
            string truckDepartureDate = reader.GetString(1);
            reader.Close();
            command.CommandText = @$"select idlote, idlugarenvio from cargalote where matricula='{plate}' and usuario='{username}' and fechasalida='{truckDepartureDate}
                                    inner join lote on cargalote.idlote=lote.idlote'";
            reader = command.ExecuteReader();
            var bundlesInTruck = new List<Bundle>();
            while (reader.Read()) {
                bundlesInTruck.Add(new Bundle(reader.GetInt32(0), reader.GetInt32(1)));
            }
            reader.Close();
            return new {
                success = true,
                message = "bundles in truck retrieved successfully",
                packages = bundlesInTruck.ToArray()
            };
        }
        catch (Exception ex) {
            return new {
                message = "error while retrieving bundles",
                exception = ex.ToString() + ex.Message
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

    private bool VerifyCredentialsForOthers(Verification ver) {
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
