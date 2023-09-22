namespace WindowsFormsApp1
{
    partial class Monitoreo
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
            this.tblMonitoreo = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxTabla = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonitoreo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMonitoreo
            // 
            this.tblMonitoreo.AllowUserToAddRows = false;
            this.tblMonitoreo.AllowUserToDeleteRows = false;
            this.tblMonitoreo.AllowUserToResizeRows = false;
            this.tblMonitoreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMonitoreo.Location = new System.Drawing.Point(20, 115);
            this.tblMonitoreo.Name = "tblMonitoreo";
            this.tblMonitoreo.Size = new System.Drawing.Size(572, 282);
            this.tblMonitoreo.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tabla:";
            // 
            // cbxTabla
            // 
            this.cbxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabla.FormattingEnabled = true;
            this.cbxTabla.Location = new System.Drawing.Point(71, 78);
            this.cbxTabla.Name = "cbxTabla";
            this.cbxTabla.Size = new System.Drawing.Size(114, 21);
            this.cbxTabla.TabIndex = 40;
            this.cbxTabla.DropDown += new System.EventHandler(this.cbxTabla_DropDown);
            this.cbxTabla.SelectedIndexChanged += new System.EventHandler(this.cbxTabla_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(243, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 27);
            this.label15.TabIndex = 41;
            this.label15.Text = "Monitoreo";
            // 
            // Monitoreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxTabla);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tblMonitoreo);
            this.Name = "Monitoreo";
            this.Size = new System.Drawing.Size(612, 415);
            ((System.ComponentModel.ISupportInitialize)(this.tblMonitoreo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblMonitoreo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxTabla;
        private System.Windows.Forms.Label label15;
    }
}
