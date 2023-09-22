using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Asignar : UserControl
    {
        public Asignar()
        {
            InitializeComponent();
        }

        private async void pnlAsignarAlmacen_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select idrol from proyecto.usuario where usuario='{cbxAsignarAlmacenero.SelectedItem.ToString()}'";
                    var reader = await command.ExecuteReaderAsync();
                    reader.Read();
                    if (reader.GetInt32(0) != 2)
                    {
                        MessageBox.Show("El usuario debe ser almacenero");
                        return;
                    }
                    reader.Close();
                    command.CommandText = $"insert into proyecto.almacenero values ('{cbxAsignarAlmacenero.SelectedItem.ToString()}', {cbxAlmacen.SelectedItem.ToString()})";
                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Usuario asignado correctamente al almacén");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al asignar el usuario al almacén" + ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblAsignarAlmacen_Click(object sender, EventArgs e)
        {
            pnlAsignarAlmacen_Click(sender, e);
        }

        private async void pnlAsignarCamion_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select idrol from proyecto.usuario where usuario='{cbxAsignarCamionero.SelectedItem.ToString()}'";
                    var reader = await command.ExecuteReaderAsync();
                    reader.Read();
                    if (reader.GetInt32(0) != 3)
                    {
                        MessageBox.Show("El usuario debe ser camionero");
                        return;
                    }
                    reader.Close();
                    var anio = DateTime.Now.ToString("yyyy");
                    var mes = DateTime.Now.ToString("MM");
                    var dia = DateTime.Now.ToString("dd");
                    var hora = DateTime.Now.ToString("hh:mm:ss");
                    command.CommandText = $@"start transaction;
                        insert into proyecto.conductor values ('{cbxAsignarCamionero.SelectedItem.ToString()}', '{txtLicencia.Text}');
                        insert into proyecto.conduce
                            values ('{cbxAsignarCamionero.SelectedItem.ToString()}', '{cbxCamion.SelectedItem.ToString()}', '{anio}-{mes}-{dia}', '{hora}');
                        commit;";
                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Usuario asignado correctamente al almacén");
                }
                catch (Exception ex)
                {
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = "rollback;";
                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Error al asignar el usuario al camión" + ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblAsignarCamion_Click(object sender, EventArgs e)
        {
            pnlAsignarCamion_Click(sender, e);
        }

        private async void cbxAsignarAlmacenero_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select usuario from proyecto.usuario";
                    var reader = await command.ExecuteReaderAsync();
                    cbxAsignarAlmacenero.Items.Clear();
                    while (reader.Read())
                        cbxAsignarAlmacenero.Items.Add(reader.GetString(0));
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

        private async void cbxAlmacen_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select idlugarenvio from proyecto.almacen";
                    var reader = await command.ExecuteReaderAsync();
                    cbxAlmacen.Items.Clear();
                    while (reader.Read())
                        cbxAlmacen.Items.Add(reader.GetInt32(0).ToString());
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private async void cbxAsignarCamionero_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select usuario from proyecto.usuario";
                    var reader = await command.ExecuteReaderAsync();
                    cbxAsignarCamionero.Items.Clear();
                    while (reader.Read())
                        cbxAsignarCamionero.Items.Add(reader.GetString(0));
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

        private async void cbxCamion_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select matricula from proyecto.camion";
                    var reader = await command.ExecuteReaderAsync();
                    cbxCamion.Items.Clear();
                    while (reader.Read())
                        cbxCamion.Items.Add(reader.GetString(0));
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
