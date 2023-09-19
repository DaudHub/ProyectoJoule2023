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

        private void pnlINiciar_Click(object sender, EventArgs e)
        {
            if (!VerifyUser(txtUsuario.Text, txtContraseña.Text))
                MessageBox.Show("Error de verificación");
            else /*codigo para mostrar el siguiente formulario*/;
        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            pnlINiciar_Click(sender, e);
        }

        private bool VerifyUser(string username, string password)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    db_conn.Open();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"select usuario, pwd from proyecto.usuario where usuario='{username}' and pwd='{MyEncryption.EncryptToString(password)}'";
                    var reader = command.ExecuteReader();
                    if (!reader.HasRows) return false;
                    else return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    db_conn.Close();
                }
            }
        }

    }
}
