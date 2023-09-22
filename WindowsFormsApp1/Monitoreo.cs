using System;
using System.CodeDom;
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
    public partial class Monitoreo : UserControl
    {
        public Monitoreo()
        {
            InitializeComponent();
        }

        private async void cbxTabla_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = @"SELECT TABLE_NAME 
                                            FROM INFORMATION_SCHEMA.TABLES 
                                            WHERE TABLE_SCHEMA = 'proyecto';";
                    var reader = await command.ExecuteReaderAsync();
                    cbxTabla.Items.Clear();
                    while (reader.Read())
                    {
                        cbxTabla.Items.Add(reader.GetString(0));
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

        private async void cbxTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"SELECT COLUMN_NAME 
                                            FROM INFORMATION_SCHEMA.COLUMNS 
                                            WHERE TABLE_SCHEMA = 'proyecto' 
                                            AND TABLE_NAME = '{cbxTabla.SelectedItem.ToString()}';";
                    var reader = await command.ExecuteReaderAsync();
                    tblMonitoreo.Columns.Clear();
                    tblMonitoreo.Rows.Clear();
                    DataGridViewColumn columna;
                    while (reader.Read())
                    {
                        columna = new DataGridViewTextBoxColumn();
                        columna.HeaderText = reader.GetString(0);
                        columna.ReadOnly = true;
                        tblMonitoreo.Columns.Add(columna);
                    }
                    reader.Close();
                    command.CommandText = $"select * from proyecto.{cbxTabla.SelectedItem.ToString()}";
                    reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        var row = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetValue(i).ToString());
                        }
                        tblMonitoreo.Rows.Add(row.ToArray());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }
    }
}
