using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CRUD
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new UserMenu().Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Program.db_conn.Open();
                var command = new MySqlCommand($"delete from proyecto.usuarios where usuario='{txtUsuario.Text}' and pwd='{MyEncryption.EncryptToString(txtContrasena.Text)}'", Program.db_conn);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0) throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar eliminar usuario");
            }
            finally
            {
                Program.db_conn.Close();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox) ctrl.Text = null;
                }
            }
        }

        private void pbxVer_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = txtContrasena.UseSystemPasswordChar ? false : true;
        }
    }
}
