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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new UserMenu().Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Program.db_conn.Open();
                var command = new MySqlCommand($"update proyecto.usuarios set usuario='{txtUsuarioNuevo.Text}' where usuario='{txtUsuarioViejo.Text}' and pwd='{MyEncryption.EncryptToString(txtContrasena.Text)}'",
                    Program.db_conn);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0) throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("error al intentar modificar el usuario");
            }
            finally
            {
                Program.db_conn.Close();
                foreach (Control panel in this.Controls)
                    if (panel is Panel) 
                        foreach (Control ctrl in panel.Controls)
                            if (ctrl is TextBox) ctrl.Text = null;
            }
        }

        private void btnModificarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                Program.db_conn.Open();
                var command = new MySqlCommand($"update proyecto.usuarios set pwd='{MyEncryption.EncryptToString(txtContrasenaNueva.Text)}' where usuario='{txtUsuario.Text}' and pwd='{MyEncryption.EncryptToString(txtContrasenaVieja.Text)}'",
                    Program.db_conn);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0) throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("error al intentar modificar el la contraseña");
            }
            finally
            {
                Program.db_conn.Close();
                foreach (Control ctrl in this.Controls)
                    if (ctrl is TextBox) ctrl.Text = null;
            }
        }
    }
}
