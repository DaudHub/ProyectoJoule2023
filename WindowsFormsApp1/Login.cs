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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private async void pnlINiciar_Click(object sender, EventArgs e)
        {
            if (!await VerifyUser(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Error de verificación");
                return;
            }
            Hide();
            new Admin(txtUsuario.Text).Show();
        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            pnlINiciar_Click(sender, e);
        }

        private async Task<bool> VerifyUser(string username, string password)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select usuario, pwd from proyecto.usuario where usuario='{username}' and pwd='{MyEncryption.EncryptToString(password)}' and idrol=1";
                    var reader = await command.ExecuteReaderAsync();
                    if (!reader.HasRows) return false;
                    else return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

    }
}
