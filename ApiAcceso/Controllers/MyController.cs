using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using MySqlConnector;
using System.Security.Cryptography;
using System.Threading;
using RestAPI;
using Microsoft.Win32;

namespace RestAPI.Controllers{

    [ApiController]
    [Route("api")]
    public class MyController : Controller
    {
        MySqlConnection db_conn = new MySqlConnection("Server=127.0.0.1;User ID=accessapi;Password=kwefbwibcakebvuyevbiubqury38");

        [HttpPost]
        [Route("gettoken")]
        public dynamic GetToken([FromBody] User user) {
            try {
                db_conn.Open();
                var command = new MySqlCommand($"select usuario, pwd from proyecto.usuario where usuario='{user.Username}' and pwd='{MyEncryption.EncryptToString(user.Password)}'", db_conn);
                var reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows) return new {
                    success = false,
                    message = "authentication error"
                };
                reader.Read();
                string token = new MyTokenGenerator().GenerateToken();
                db_conn.Close();
                db_conn.Open();
                command = new MySqlCommand($"insert into proyecto.tokens values ('{user.Username}', '{token}')", db_conn);
                command.ExecuteNonQuery();
                return new {
                    success = true,
                    message = $"token created successfully for user {user.Username}",
                    token = token
                };
            }
            catch (Exception e) {
                return new {
                    success = false,
                    message = "error while obtaining new key",
                    exception = e.ToString()
                };
            }
            finally {
                db_conn.Close();
            }
        }

        [HttpPost]
        [Route("verify")]
        public dynamic VerifyUser([FromBody] User user) {
            try {
                db_conn.Open();
                var command = new MySqlCommand($"select usuario, pwd from proyecto.usuario where usuario='{user.Username}' and pwd='{MyEncryption.EncryptToString(user.Password)}'", db_conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows) return new {
                    success = false,
                    message = "incorrect password or user does not exist"
                };
                else return new {
                    success = true,
                    message = "user authenticated correctly"
                };
            }
            catch(Exception e) {
                return new {
                    success = false,
                    message = "error while trying to verify user",
                    exception = e.ToString()
                };
            } finally {
                db_conn.Close();
            }
        }
        
    }

}