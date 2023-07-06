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

namespace CRUD
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
            new UserMenu().Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Program.db_conn.Open();
                var command = new MySqlCommand(@$"insert into proyecto.usuarios (usuario, pwd, rol, nombre, apellido)
                    values ('{txtUsuario.Text}','{MyEncryption.EncryptToString(txtContrasena.Text)}','{cbxRol.SelectedItem?.ToString()}','{txtNombre.Text}','{txtApellido.Text}')",
                    Program.db_conn);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear el usuario");
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