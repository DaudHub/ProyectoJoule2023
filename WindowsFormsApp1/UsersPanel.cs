using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySqlConnector;

namespace WindowsFormsApp1
{
    public partial class UsersPanel : UserControl
    {

        Dictionary<string, byte> roles = new Dictionary<string, byte>()
        {
            {"administrador", 1},
            {"almacenero", 2},
            {"camionero", 3},
            {"cliente", 4}
        };

        Dictionary<string, string> atributosUsuario = new Dictionary<string, string>()
        {
            {"usuario", "usuario"},
            {"contraseña", "pwd"},
            {"rol", "idrol"},
            {"nombre", "nombre"},
            {"apellido", "apellido"}
        };

        public UsersPanel()
        {
            InitializeComponent();
            UpdateTable();
        }

        private async void pnlCrearUsuario_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText =
                        $@"insert into proyecto.usuario
                        values ('{txtCrearUsuario.Text}', {roles[cbxCrearRol.SelectedItem.ToString()]}, '{MyEncryption.EncryptToString(txtCrearContraseña.Text)}', '{txtCrearNombre.Text}', '{txtCrearApellido.Text}')";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Usuario creado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear usuario");
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblCrearUsuario_Click(object sender, EventArgs e)
        {
            pnlCrearUsuario_Click(sender, e);
        }

        private async void pnlAplicar_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    string format;
                    switch(cbxAtributo.SelectedItem.ToString())
                    {
                        case "rol":
                            format = roles[txtActualizacion.Text].ToString();
                            break;
                        case "contraseña":
                            format = $"'{MyEncryption.EncryptToString(txtActualizacion.Text)}'";
                            break;
                        default:
                            format = $"'{txtActualizacion.Text}'";
                            break;
                    }
                    command.CommandText = $"update proyecto.usuario set {atributosUsuario[cbxAtributo.SelectedItem.ToString()]}={format} where usuario='{cbxModificarUsuario.SelectedItem.ToString()}'";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Usuario actualizado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar usuario");
                } 
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblAplicar_Click(object sender, EventArgs e)
        {
            pnlAplicar_Click(sender, e);
        }

        private async void cbxModificarUsuario_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select usuario from proyecto.usuario";
                    var reader = await command.ExecuteReaderAsync();
                    cbxModificarUsuario.Items.Clear();
                    while (reader.Read())
                    {
                        cbxModificarUsuario.Items.Add(reader.GetValue(0));
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }


        private async void pnlEliminar_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    if (cbxEliminarUsuario.SelectedItem.ToString() != txtConfirmar.Text)
                    {
                        MessageBox.Show("Error de confirmación");
                        return;
                    }
                    command.CommandText = $@"delete from proyecto.usuario where usuario='{cbxEliminarUsuario.SelectedItem.ToString()}'";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Usuario eliminado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el usuario. Causa probable: el usuario tiene elementos asociados" + ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblEliminar_Click(object sender, EventArgs e)
        {
            pnlEliminar_Click(sender, e);
        }

        private async void cbxEliminarUsuario_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select usuario from proyecto.usuario";
                    var reader = await command.ExecuteReaderAsync();
                    cbxEliminarUsuario.Items.Clear();
                    while (reader.Read())
                    {
                        cbxEliminarUsuario.Items.Add(reader.GetValue(0));
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private async void UpdateTable()
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select usuario.usuario, rol.nombre, usuario.nombre, usuario.apellido
                                             from proyecto.usuario
                                                inner join proyecto.rol on usuario.idrol=rol.idrol";
                    tblUsuarios.Rows.Clear();
                    var reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        tblUsuarios.Rows.Add(new string[] {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)});
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        
    }
}
