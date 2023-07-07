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
        [Route("newuser")]
        public dynamic PostUser([FromBody] User user) {
            try {
                db_conn.Open();
                var command = new MySqlCommand(@$"insert into proyecto.usuarios (usuario, pwd, rol, nombre, apellido)
                    values ('{user.Username}','{MyEncryption.EncryptToString(user.Password)}','{user.Role}','{user.Name}','{user.Surname}')", 
                    db_conn);
                command.ExecuteNonQuery();
                return new {
                    success = true,
                    message = "user added successfully"
                };
            }
            catch (Exception e) {
                return new {
                    success = false,
                    message = "error while trying to create user",
                    exception = e.ToString()
                };
            }
            finally {
                db_conn.Close();
            }
        }

        [HttpPost]
        [Route("gettoken")]
        public dynamic GetToken([FromBody] User user) {
            try {
                db_conn.Open();
                var command = new MySqlCommand($"select usuario, pwd from proyecto.usuarios where usuario='{user.Username}' and pwd='{MyEncryption.EncryptToString(user.Password)}'", db_conn);
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
                command = new MySqlCommand($"insert into proyecto.tokens values ('{token}', '{user.Username}')", db_conn);
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
                var command = new MySqlCommand($"select usuario, pwd from proyecto.usuarios where usuario='{user.Username}' and pwd='{MyEncryption.EncryptToString(user.Password)}'", db_conn);
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

        [HttpPut]
        [Route("updateuser")]
        public dynamic UpdateUserName(string user, string newuser, string password) {
            try {
                db_conn.Open();
                var command = new MySqlCommand($"update proyecto.usuarios set usuario='{newuser}' where usuario='{user}' and pwd='{MyEncryption.EncryptToString(password)}'", db_conn);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0) return new {
                    success = false,
                    message = "user does no exist or password is incorrect"
                };
                return new {
                    success = true,
                    message = "user updated successfully"
                };
            }
            catch (Exception e) {
                return new {
                    success = false,
                    message = "error while trying to update user",
                    exception = e.ToString()
                };
            }
            finally {
                db_conn.Close();
            }
        }

        [HttpPut]
        [Route("updatepassword")]
        public dynamic UpdatePassword(string user, string password, string newpassword) {
            try {
                db_conn.Open();
                var command = new MySqlCommand($"update proyecto.usuarios set pwd='{MyEncryption.EncryptToString(newpassword)}' where usuario='{user}' and pwd='{MyEncryption.EncryptToString(password)}'", db_conn);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0) return new {
                    success = false,
                    message = "user does no exist or password is incorrect"
                };
                return new {
                    success = true,
                    message = "password updated successfully"
                };
            }
            catch (Exception e) {
                return new {
                    success = false,
                    message = "error while trying to update password",
                    exception = e.ToString()
                };
            }
            finally {
                db_conn.Close();
            }
        }

        [HttpDelete]
        [Route("deleteuser")]
        public dynamic DeleteUser([FromBody] User user) {
            try {
                db_conn.Open();
                var command = new MySqlCommand($"delete from proyecto.usuarios where usuario='{user.Username}' and pwd='{MyEncryption.EncryptToString(user.Password)}'", db_conn);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0) return new {
                    success = false,
                    message = "user does no exist or password is incorrect"
                };
                return new {
                    success = true,
                    message = $"user '{user.Username}' deleted succesfully"
                };
            }
            catch (Exception e) {
                return new {
                    success = false,
                    message = $"error while trying to delete user '{user.Username}'",
                    exception = e.ToString()
                };
            }
            finally{
                db_conn.Close();
            }
        }
        
    }

}