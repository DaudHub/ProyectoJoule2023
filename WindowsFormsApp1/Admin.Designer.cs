namespace WindowsFormsApp1
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pnlAlmacenes = new System.Windows.Forms.Panel();
            this.lblAlmacenes = new System.Windows.Forms.Label();
            this.pnlMonitoreo = new System.Windows.Forms.Panel();
            this.lblMonitoreo = new System.Windows.Forms.Label();
            this.pnlAsignar = new System.Windows.Forms.Panel();
            this.lblAsignar = new System.Windows.Forms.Label();
            this.pnlCamiones = new System.Windows.Forms.Panel();
            this.lblCamiones = new System.Windows.Forms.Label();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pcbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlSesion = new System.Windows.Forms.Panel();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.pnlAlmacenes.SuspendLayout();
            this.pnlMonitoreo.SuspendLayout();
            this.pnlAsignar.SuspendLayout();
            this.pnlCamiones.SuspendLayout();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).BeginInit();
            this.pnlSesion.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.SidePanel.Controls.Add(this.pnlAlmacenes);
            this.SidePanel.Controls.Add(this.pnlMonitoreo);
            this.SidePanel.Controls.Add(this.pnlAsignar);
            this.SidePanel.Controls.Add(this.pnlCamiones);
            this.SidePanel.Controls.Add(this.pnlUsuarios);
            this.SidePanel.Controls.Add(this.pcbxLogo);
            this.SidePanel.Controls.Add(this.pnlSesion);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(188, 450);
            this.SidePanel.TabIndex = 1;
            // 
            // pnlAlmacenes
            // 
            this.pnlAlmacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAlmacenes.Controls.Add(this.lblAlmacenes);
            this.pnlAlmacenes.Location = new System.Drawing.Point(14, 185);
            this.pnlAlmacenes.Name = "pnlAlmacenes";
            this.pnlAlmacenes.Size = new System.Drawing.Size(159, 34);
            this.pnlAlmacenes.TabIndex = 2;
            this.pnlAlmacenes.Click += new System.EventHandler(this.pnlAlmacenes_Click);
            // 
            // lblAlmacenes
            // 
            this.lblAlmacenes.AutoSize = true;
            this.lblAlmacenes.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenes.ForeColor = System.Drawing.Color.White;
            this.lblAlmacenes.Location = new System.Drawing.Point(24, 4);
            this.lblAlmacenes.Name = "lblAlmacenes";
            this.lblAlmacenes.Size = new System.Drawing.Size(111, 27);
            this.lblAlmacenes.TabIndex = 2;
            this.lblAlmacenes.Text = "Almacenes";
            this.lblAlmacenes.Click += new System.EventHandler(this.lblAlmacenes_Click);
            // 
            // pnlMonitoreo
            // 
            this.pnlMonitoreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlMonitoreo.Controls.Add(this.lblMonitoreo);
            this.pnlMonitoreo.Location = new System.Drawing.Point(14, 331);
            this.pnlMonitoreo.Name = "pnlMonitoreo";
            this.pnlMonitoreo.Size = new System.Drawing.Size(159, 34);
            this.pnlMonitoreo.TabIndex = 4;
            this.pnlMonitoreo.Click += new System.EventHandler(this.pnlMonitoreo_Click);
            // 
            // lblMonitoreo
            // 
            this.lblMonitoreo.AutoSize = true;
            this.lblMonitoreo.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitoreo.ForeColor = System.Drawing.Color.White;
            this.lblMonitoreo.Location = new System.Drawing.Point(25, 3);
            this.lblMonitoreo.Name = "lblMonitoreo";
            this.lblMonitoreo.Size = new System.Drawing.Size(109, 27);
            this.lblMonitoreo.TabIndex = 4;
            this.lblMonitoreo.Text = "Monitoreo";
            this.lblMonitoreo.Click += new System.EventHandler(this.lblMonitoreo_Click);
            // 
            // pnlAsignar
            // 
            this.pnlAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAsignar.Controls.Add(this.lblAsignar);
            this.pnlAsignar.Location = new System.Drawing.Point(14, 282);
            this.pnlAsignar.Name = "pnlAsignar";
            this.pnlAsignar.Size = new System.Drawing.Size(159, 34);
            this.pnlAsignar.TabIndex = 3;
            this.pnlAsignar.Click += new System.EventHandler(this.PnlAsignar_Click);
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignar.ForeColor = System.Drawing.Color.White;
            this.lblAsignar.Location = new System.Drawing.Point(39, 3);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(81, 27);
            this.lblAsignar.TabIndex = 3;
            this.lblAsignar.Text = "Asignar";
            this.lblAsignar.Click += new System.EventHandler(this.lblAsignar_Click);
            // 
            // pnlCamiones
            // 
            this.pnlCamiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCamiones.Controls.Add(this.lblCamiones);
            this.pnlCamiones.Location = new System.Drawing.Point(14, 234);
            this.pnlCamiones.Name = "pnlCamiones";
            this.pnlCamiones.Size = new System.Drawing.Size(159, 34);
            this.pnlCamiones.TabIndex = 2;
            this.pnlCamiones.Click += new System.EventHandler(this.pnlCamiones_Click);
            // 
            // lblCamiones
            // 
            this.lblCamiones.AutoSize = true;
            this.lblCamiones.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamiones.ForeColor = System.Drawing.Color.White;
            this.lblCamiones.Location = new System.Drawing.Point(27, 3);
            this.lblCamiones.Name = "lblCamiones";
            this.lblCamiones.Size = new System.Drawing.Size(103, 27);
            this.lblCamiones.TabIndex = 3;
            this.lblCamiones.Text = "Camiones";
            this.lblCamiones.Click += new System.EventHandler(this.lblCamiones_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlUsuarios.Controls.Add(this.lblUsuarios);
            this.pnlUsuarios.Location = new System.Drawing.Point(14, 137);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(159, 34);
            this.pnlUsuarios.TabIndex = 1;
            this.pnlUsuarios.Click += new System.EventHandler(this.pnlUsuarios_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Location = new System.Drawing.Point(31, 4);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(93, 27);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuarios";
            this.lblUsuarios.Click += new System.EventHandler(this.lblUsuarios_Click);
            // 
            // pcbxLogo
            // 
            this.pcbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbxLogo.Image")));
            this.pcbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbxLogo.Name = "pcbxLogo";
            this.pcbxLogo.Size = new System.Drawing.Size(159, 92);
            this.pcbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLogo.TabIndex = 0;
            this.pcbxLogo.TabStop = false;
            // 
            // pnlSesion
            // 
            this.pnlSesion.Controls.Add(this.pnlCerrarSesion);
            this.pnlSesion.Location = new System.Drawing.Point(14, 371);
            this.pnlSesion.Name = "pnlSesion";
            this.pnlSesion.Size = new System.Drawing.Size(159, 72);
            this.pnlSesion.TabIndex = 0;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCerrarSesion.Controls.Add(this.lblCerrarSesion);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(35, 43);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(89, 24);
            this.pnlCerrarSesion.TabIndex = 5;
            this.pnlCerrarSesion.Click += new System.EventHandler(this.pnlCerrarSesion_Click);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(10, 6);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(70, 13);
            this.lblCerrarSesion.TabIndex = 0;
            this.lblCerrarSesion.Text = "Cerrar Sesión";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBackground.Location = new System.Drawing.Point(188, 35);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(612, 415);
            this.pnlBackground.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.SidePanel.ResumeLayout(false);
            this.pnlAlmacenes.ResumeLayout(false);
            this.pnlAlmacenes.PerformLayout();
            this.pnlMonitoreo.ResumeLayout(false);
            this.pnlMonitoreo.PerformLayout();
            this.pnlAsignar.ResumeLayout(false);
            this.pnlAsignar.PerformLayout();
            this.pnlCamiones.ResumeLayout(false);
            this.pnlCamiones.PerformLayout();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).EndInit();
            this.pnlSesion.ResumeLayout(false);
            this.pnlCerrarSesion.ResumeLayout(false);
            this.pnlCerrarSesion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pcbxLogo;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel pnlMonitoreo;
        private System.Windows.Forms.Panel pnlAsignar;
        private System.Windows.Forms.Panel pnlCamiones;
        private System.Windows.Forms.Label lblAlmacenes;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblAsignar;
        private System.Windows.Forms.Panel pnlAlmacenes;
        private System.Windows.Forms.Label lblCamiones;
        private System.Windows.Forms.Label lblMonitoreo;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Panel pnlSesion;
    }
}