using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace WindowsFormsApp1
{
    public partial class Almacenes : UserControl
    {
        public Almacenes()
        {
            InitializeComponent();
            UpdateTable();
        }

        Dictionary<string, string> atributosAlmacen = new Dictionary<string, string>()
        {
            {"ID", "idlugarenvio"},
            {"latitud", "latitud"},
            {"longitud", "longitud"},
            {"calle", "calle"},
            {"n°puerta", "numeropuerta"},
            {"capacidad(m3)", "volumenm3"},
            {"capacidad(Kg)", "capacidadkg"}
        };

        private async void pnlCrearAlmacen_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"start transaction;
                    insert into proyecto.lugarenvio values
                    ({txtID.Text}, {txtLatitud.Text}, {txtLongitud.Text}, '{txtCalle.Text}', {txtNumeroPuerta.Text});
                    insert into proyecto.almacen values
                    ({txtID.Text}, {txtCapacidadKg.Text}, {txtCapacidadm3.Text});
                    commit";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Almacén creado con éxito");
                }
                catch (Exception ex)
                {
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = "rollback;";
                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Error al intentar crear el almacén");
                }
                finally {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblCrearAlmacen_Click(object sender, EventArgs e)
        {
            pnlCrearAlmacen_Click(sender, e);
        }

        private async void cbxModificarAlmacen_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = "select idlugarenvio from proyecto.almacen";
                    var reader = await command.ExecuteReaderAsync();
                    cbxModificarAlmacen.Items.Clear();
                    while (reader.Read())
                        cbxModificarAlmacen.Items.Add(reader.GetValue(0));
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

        private async void pnlAplicarAlmacen_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    string table;
                    if (new string[] {"latitud", "longitud", "calle", "n°puerta"}.Contains<string>(cbxAtributoAlmacen.SelectedItem.ToString()))
                        table = "proyecto.lugarenvio";
                    else
                        table = "proyecto.almacen";
                    string format;
                    if (new string[] { "latitud", "longitud" }.Contains<string>(cbxAtributoAlmacen.SelectedItem.ToString()))
                        format = $"{decimal.Parse(txtActualizacionAlmacen.Text)}";
                    else if (new string[] { "n°puerta", "capacidad(Kg)", "capacidad(m3)" }.Contains<string>(cbxAtributoAlmacen.SelectedItem.ToString()))
                        format = $"{int.Parse(txtActualizacionAlmacen.Text)}";
                    else
                        format = $"'{txtActualizacionAlmacen.Text}'";
                    command.CommandText = $@"update {table} set {atributosAlmacen[cbxAtributoAlmacen.SelectedItem.ToString()]}={format} where idlugarenvio={int.Parse(cbxModificarAlmacen.SelectedItem.ToString())}";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Almacén modificado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar modificar el almacén");
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblAplicarAlmacen_Click(object sender, EventArgs e)
        {
            pnlAplicarAlmacen_Click(sender, e);
        }

        private async void cbxEliminarAlmacen_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = "select idlugarenvio from proyecto.almacen";
                    var reader = await command.ExecuteReaderAsync();
                    cbxEliminarAlmacen.Items.Clear();
                    while (reader.Read())
                        cbxEliminarAlmacen.Items.Add(reader.GetValue(0));
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

        private async void pnlEliminarAlmacen_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    if (cbxEliminarAlmacen.SelectedItem.ToString() != txtConfirmarAlmacen.Text)
                    {
                        MessageBox.Show("Error de confirmación");
                        return;
                    }
                    command.CommandText = $"delete from proyecto.almacen where idlugarenvio={cbxEliminarAlmacen.SelectedItem.ToString()}";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Almacén eliminado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el almacén");
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblEliminarAlmacen_Click(object sender, EventArgs e)
        {
            pnlEliminarAlmacen_Click(sender, e);
        }

        private async void UpdateTable()
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = @"select almacen.idlugarenvio, latitud, longitud, calle, numeropuerta, capacidadkg, volumenm3
                                            from proyecto.lugarenvio inner join proyecto.almacen on lugarenvio.idlugarenvio=almacen.idlugarenvio";
                    var reader = await command.ExecuteReaderAsync();
                    tblAlmacenes.Rows.Clear();
                    while (reader.Read())
                    {
                        tblAlmacenes.Rows.Add(new string[] {reader.GetInt32(0).ToString(), reader.GetDecimal(1).ToString(), reader.GetDecimal(2).ToString(), reader.GetString(3), reader.GetInt32(4).ToString(), reader.GetInt32(5).ToString(), reader.GetInt32(6).ToString()});
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
