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
            this.pcbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.SidePanel.Controls.Add(this.pcbxLogo);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(188, 450);
            this.SidePanel.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(240, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).EndInit();
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
    }
}