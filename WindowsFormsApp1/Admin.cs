using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {

        UsersPanel usersPanel;
        Almacenes almacenes;
        Camiones camiones;
        Asignar asignar;
        Monitoreo monitoreo;

        public Admin(string name)
        {
            InitializeComponent();
            usersPanel = new UsersPanel();
            almacenes = new Almacenes();
            camiones = new Camiones();
            asignar = new Asignar();
            monitoreo = new Monitoreo();
            pnlBackground.Controls.Add(new UsersPanel());
            UpdateButtons((Panel)SidePanel.Controls["pnlUsuarios"]);
        }

        private void UpdateButtons(Panel pressed)
        {
            foreach (Control pnl in SidePanel.Controls)
            {
                if(pnl != pressed && pnl is Panel)
                    pnl.BackColor = SidePanel.BackColor;
                else pnl.BackColor = Color.FromArgb(49, 133, 185);
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlUsuarios_Click(object sender, EventArgs e)
        {
            UpdateButtons((Panel)sender);
            pnlBackground.Controls.Clear();
            pnlBackground.Controls.Add(usersPanel);
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            pnlUsuarios_Click(pnlUsuarios, e);
        }

        private void pnlAlmacenes_Click(object sender, EventArgs e)
        {
            UpdateButtons((Panel)sender);
            pnlBackground.Controls.Clear();
            pnlBackground.Controls.Add(almacenes);
        }

        private void lblAlmacenes_Click(object sender, EventArgs e)
        {
            pnlAlmacenes_Click(pnlAlmacenes, e);
        }

        private void pnlCamiones_Click(object sender, EventArgs e)
        {
            UpdateButtons((Panel)sender);
            pnlBackground.Controls.Clear();
            pnlBackground.Controls.Add(camiones);
        }

        private void lblCamiones_Click(object sender, EventArgs e)
        {
            pnlCamiones_Click(pnlCamiones, e);
        }

        private void PnlAsignar_Click(object sender, EventArgs e)
        {
            UpdateButtons((Panel)sender);
            pnlBackground.Controls.Clear();
            pnlBackground.Controls.Add(asignar);
        }

        private void lblAsignar_Click(object sender, EventArgs e)
        {
            PnlAsignar_Click(pnlAsignar, e);
        }

        private void pnlMonitoreo_Click(object sender, EventArgs e)
        {
            UpdateButtons((Panel)sender);
            pnlBackground.Controls.Clear();
            pnlBackground.Controls.Add(monitoreo);
        }

        private void lblMonitoreo_Click(object sender, EventArgs e)
        {
            pnlMonitoreo_Click(pnlMonitoreo, e);
        }

        private void pnlCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.login.Show();
            this.Dispose();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion_Click(sender, e);
        }
    }
}
