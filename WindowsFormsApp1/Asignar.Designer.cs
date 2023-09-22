namespace WindowsFormsApp1
{
    partial class Asignar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxAsignarAlmacenero = new System.Windows.Forms.ComboBox();
            this.pnlAsignarAlmacen = new System.Windows.Forms.Panel();
            this.lbAsignarAlmacen = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCamion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAsignarCamionero = new System.Windows.Forms.ComboBox();
            this.pnlAsignarCamion = new System.Windows.Forms.Panel();
            this.lblAsignarCamion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAsignarAlmacen.SuspendLayout();
            this.pnlAsignarCamion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxAsignarAlmacenero
            // 
            this.cbxAsignarAlmacenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAsignarAlmacenero.FormattingEnabled = true;
            this.cbxAsignarAlmacenero.Location = new System.Drawing.Point(142, 174);
            this.cbxAsignarAlmacenero.Name = "cbxAsignarAlmacenero";
            this.cbxAsignarAlmacenero.Size = new System.Drawing.Size(104, 21);
            this.cbxAsignarAlmacenero.TabIndex = 39;
            this.cbxAsignarAlmacenero.DropDown += new System.EventHandler(this.cbxAsignarAlmacenero_DropDown);
            // 
            // pnlAsignarAlmacen
            // 
            this.pnlAsignarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAsignarAlmacen.Controls.Add(this.lbAsignarAlmacen);
            this.pnlAsignarAlmacen.Location = new System.Drawing.Point(119, 236);
            this.pnlAsignarAlmacen.Name = "pnlAsignarAlmacen";
            this.pnlAsignarAlmacen.Size = new System.Drawing.Size(98, 22);
            this.pnlAsignarAlmacen.TabIndex = 38;
            this.pnlAsignarAlmacen.Click += new System.EventHandler(this.pnlAsignarAlmacen_Click);
            // 
            // lbAsignarAlmacen
            // 
            this.lbAsignarAlmacen.AutoSize = true;
            this.lbAsignarAlmacen.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsignarAlmacen.ForeColor = System.Drawing.Color.White;
            this.lbAsignarAlmacen.Location = new System.Drawing.Point(23, 2);
            this.lbAsignarAlmacen.Name = "lbAsignarAlmacen";
            this.lbAsignarAlmacen.Size = new System.Drawing.Size(51, 17);
            this.lbAsignarAlmacen.TabIndex = 12;
            this.lbAsignarAlmacen.Text = "Asignar";
            this.lbAsignarAlmacen.Click += new System.EventHandler(this.lblAsignarAlmacen_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(82, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Usuario:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(80, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 27);
            this.label15.TabIndex = 35;
            this.label15.Text = "Asignar Almacén";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(146, 201);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(100, 21);
            this.cbxAlmacen.TabIndex = 41;
            this.cbxAlmacen.DropDown += new System.EventHandler(this.cbxAlmacen_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Almacen:";
            // 
            // cbxCamion
            // 
            this.cbxCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCamion.FormattingEnabled = true;
            this.cbxCamion.Location = new System.Drawing.Point(403, 227);
            this.cbxCamion.Name = "cbxCamion";
            this.cbxCamion.Size = new System.Drawing.Size(105, 21);
            this.cbxCamion.TabIndex = 47;
            this.cbxCamion.DropDown += new System.EventHandler(this.cbxCamion_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Camión:";
            // 
            // cbxAsignarCamionero
            // 
            this.cbxAsignarCamionero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAsignarCamionero.FormattingEnabled = true;
            this.cbxAsignarCamionero.Location = new System.Drawing.Point(404, 174);
            this.cbxAsignarCamionero.Name = "cbxAsignarCamionero";
            this.cbxAsignarCamionero.Size = new System.Drawing.Size(104, 21);
            this.cbxAsignarCamionero.TabIndex = 45;
            this.cbxAsignarCamionero.DropDown += new System.EventHandler(this.cbxAsignarCamionero_DropDown);
            // 
            // pnlAsignarCamion
            // 
            this.pnlAsignarCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAsignarCamion.Controls.Add(this.lblAsignarCamion);
            this.pnlAsignarCamion.Location = new System.Drawing.Point(381, 261);
            this.pnlAsignarCamion.Name = "pnlAsignarCamion";
            this.pnlAsignarCamion.Size = new System.Drawing.Size(98, 22);
            this.pnlAsignarCamion.TabIndex = 44;
            this.pnlAsignarCamion.Click += new System.EventHandler(this.pnlAsignarCamion_Click);
            // 
            // lblAsignarCamion
            // 
            this.lblAsignarCamion.AutoSize = true;
            this.lblAsignarCamion.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarCamion.ForeColor = System.Drawing.Color.White;
            this.lblAsignarCamion.Location = new System.Drawing.Point(24, 2);
            this.lblAsignarCamion.Name = "lblAsignarCamion";
            this.lblAsignarCamion.Size = new System.Drawing.Size(51, 17);
            this.lblAsignarCamion.TabIndex = 12;
            this.lblAsignarCamion.Text = "Asignar";
            this.lblAsignarCamion.Click += new System.EventHandler(this.lblAsignarCamion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Asignar Camión";
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(404, 201);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(104, 20);
            this.txtLicencia.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Licencia:";
            // 
            // Asignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCamion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAsignarCamionero);
            this.Controls.Add(this.pnlAsignarCamion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAsignarAlmacenero);
            this.Controls.Add(this.pnlAsignarAlmacen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Name = "Asignar";
            this.Size = new System.Drawing.Size(612, 415);
            this.pnlAsignarAlmacen.ResumeLayout(false);
            this.pnlAsignarAlmacen.PerformLayout();
            this.pnlAsignarCamion.ResumeLayout(false);
            this.pnlAsignarCamion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAsignarAlmacenero;
        private System.Windows.Forms.Panel pnlAsignarAlmacen;
        private System.Windows.Forms.Label lbAsignarAlmacen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCamion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAsignarCamionero;
        private System.Windows.Forms.Panel pnlAsignarCamion;
        private System.Windows.Forms.Label lblAsignarCamion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label label3;
    }
}
