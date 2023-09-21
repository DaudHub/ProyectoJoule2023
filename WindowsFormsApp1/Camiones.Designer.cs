namespace WindowsFormsApp1
{
    partial class Camiones
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
            this.pnlCrearCamion = new System.Windows.Forms.Panel();
            this.lblCrearCamion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVolumenCamion = new System.Windows.Forms.TextBox();
            this.txtCapacidadCamion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAtributoCamion = new System.Windows.Forms.ComboBox();
            this.txtActualizacionCamion = new System.Windows.Forms.TextBox();
            this.cbxModificarCamion = new System.Windows.Forms.ComboBox();
            this.pnlAplicarCamion = new System.Windows.Forms.Panel();
            this.lblAplicarCamion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConfirmarCamion = new System.Windows.Forms.TextBox();
            this.cbxEliminarCamion = new System.Windows.Forms.ComboBox();
            this.pnlEliminarCamion = new System.Windows.Forms.Panel();
            this.lblEliminarCamion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tblCamiones = new System.Windows.Forms.DataGridView();
            this.clmMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cblCapacidadKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacidadM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCrearCamion.SuspendLayout();
            this.pnlAplicarCamion.SuspendLayout();
            this.pnlEliminarCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCrearCamion
            // 
            this.pnlCrearCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCrearCamion.Controls.Add(this.lblCrearCamion);
            this.pnlCrearCamion.Location = new System.Drawing.Point(58, 170);
            this.pnlCrearCamion.Name = "pnlCrearCamion";
            this.pnlCrearCamion.Size = new System.Drawing.Size(98, 22);
            this.pnlCrearCamion.TabIndex = 23;
            this.pnlCrearCamion.Click += new System.EventHandler(this.pnlCrearCamion_Click);
            // 
            // lblCrearCamion
            // 
            this.lblCrearCamion.AutoSize = true;
            this.lblCrearCamion.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCamion.ForeColor = System.Drawing.Color.White;
            this.lblCrearCamion.Location = new System.Drawing.Point(28, 2);
            this.lblCrearCamion.Name = "lblCrearCamion";
            this.lblCrearCamion.Size = new System.Drawing.Size(40, 17);
            this.lblCrearCamion.TabIndex = 12;
            this.lblCrearCamion.Text = "Crear";
            this.lblCrearCamion.Click += new System.EventHandler(this.lblCrearCamion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Capacidad (m3):";
            // 
            // txtVolumenCamion
            // 
            this.txtVolumenCamion.Location = new System.Drawing.Point(127, 134);
            this.txtVolumenCamion.Name = "txtVolumenCamion";
            this.txtVolumenCamion.Size = new System.Drawing.Size(62, 20);
            this.txtVolumenCamion.TabIndex = 21;
            // 
            // txtCapacidadCamion
            // 
            this.txtCapacidadCamion.Location = new System.Drawing.Point(125, 108);
            this.txtCapacidadCamion.Name = "txtCapacidadCamion";
            this.txtCapacidadCamion.Size = new System.Drawing.Size(64, 20);
            this.txtCapacidadCamion.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Capacidad (Kg):";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(80, 82);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(109, 20);
            this.txtModelo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Modelo:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(92, 56);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(97, 20);
            this.txtMatricula.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Crear Camión";
            // 
            // cbxAtributoCamion
            // 
            this.cbxAtributoCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtributoCamion.FormattingEnabled = true;
            this.cbxAtributoCamion.Items.AddRange(new object[] {
            "modelo",
            "capacidad(Kg)",
            "capacidad(m3)"});
            this.cbxAtributoCamion.Location = new System.Drawing.Point(283, 86);
            this.cbxAtributoCamion.Name = "cbxAtributoCamion";
            this.cbxAtributoCamion.Size = new System.Drawing.Size(104, 21);
            this.cbxAtributoCamion.TabIndex = 50;
            // 
            // txtActualizacionCamion
            // 
            this.txtActualizacionCamion.Location = new System.Drawing.Point(313, 113);
            this.txtActualizacionCamion.Name = "txtActualizacionCamion";
            this.txtActualizacionCamion.Size = new System.Drawing.Size(74, 20);
            this.txtActualizacionCamion.TabIndex = 49;
            // 
            // cbxModificarCamion
            // 
            this.cbxModificarCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModificarCamion.FormattingEnabled = true;
            this.cbxModificarCamion.Location = new System.Drawing.Point(287, 59);
            this.cbxModificarCamion.Name = "cbxModificarCamion";
            this.cbxModificarCamion.Size = new System.Drawing.Size(100, 21);
            this.cbxModificarCamion.TabIndex = 48;
            this.cbxModificarCamion.DropDown += new System.EventHandler(this.cbxModificarCamion_DropDown);
            // 
            // pnlAplicarCamion
            // 
            this.pnlAplicarCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAplicarCamion.Controls.Add(this.lblAplicarCamion);
            this.pnlAplicarCamion.Location = new System.Drawing.Point(253, 147);
            this.pnlAplicarCamion.Name = "pnlAplicarCamion";
            this.pnlAplicarCamion.Size = new System.Drawing.Size(98, 22);
            this.pnlAplicarCamion.TabIndex = 47;
            this.pnlAplicarCamion.Click += new System.EventHandler(this.pnlAplicarCamion_Click);
            // 
            // lblAplicarCamion
            // 
            this.lblAplicarCamion.AutoSize = true;
            this.lblAplicarCamion.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicarCamion.ForeColor = System.Drawing.Color.White;
            this.lblAplicarCamion.Location = new System.Drawing.Point(27, 2);
            this.lblAplicarCamion.Name = "lblAplicarCamion";
            this.lblAplicarCamion.Size = new System.Drawing.Size(48, 17);
            this.lblAplicarCamion.TabIndex = 12;
            this.lblAplicarCamion.Text = "Aplicar";
            this.lblAplicarCamion.Click += new System.EventHandler(this.lblAplicarCamion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Actualización:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(223, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Atributo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(223, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "Camión";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(221, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 27);
            this.label13.TabIndex = 43;
            this.label13.Text = "Modificar Camión";
            // 
            // txtConfirmarCamion
            // 
            this.txtConfirmarCamion.Location = new System.Drawing.Point(494, 88);
            this.txtConfirmarCamion.Name = "txtConfirmarCamion";
            this.txtConfirmarCamion.Size = new System.Drawing.Size(91, 20);
            this.txtConfirmarCamion.TabIndex = 56;
            // 
            // cbxEliminarCamion
            // 
            this.cbxEliminarCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEliminarCamion.FormattingEnabled = true;
            this.cbxEliminarCamion.Location = new System.Drawing.Point(480, 59);
            this.cbxEliminarCamion.Name = "cbxEliminarCamion";
            this.cbxEliminarCamion.Size = new System.Drawing.Size(105, 21);
            this.cbxEliminarCamion.TabIndex = 55;
            this.cbxEliminarCamion.DropDown += new System.EventHandler(this.cbxEliminarCamion_DropDown);
            // 
            // pnlEliminarCamion
            // 
            this.pnlEliminarCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlEliminarCamion.Controls.Add(this.lblEliminarCamion);
            this.pnlEliminarCamion.Location = new System.Drawing.Point(458, 121);
            this.pnlEliminarCamion.Name = "pnlEliminarCamion";
            this.pnlEliminarCamion.Size = new System.Drawing.Size(98, 22);
            this.pnlEliminarCamion.TabIndex = 54;
            this.pnlEliminarCamion.Click += new System.EventHandler(this.pnlEliminarCamion_Click);
            // 
            // lblEliminarCamion
            // 
            this.lblEliminarCamion.AutoSize = true;
            this.lblEliminarCamion.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarCamion.ForeColor = System.Drawing.Color.White;
            this.lblEliminarCamion.Location = new System.Drawing.Point(22, 2);
            this.lblEliminarCamion.Name = "lblEliminarCamion";
            this.lblEliminarCamion.Size = new System.Drawing.Size(57, 17);
            this.lblEliminarCamion.TabIndex = 12;
            this.lblEliminarCamion.Text = "Eliminar";
            this.lblEliminarCamion.Click += new System.EventHandler(this.lblEliminarCamion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(421, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Confirmar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(421, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Camión:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(427, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 27);
            this.label15.TabIndex = 51;
            this.label15.Text = "Eliminar Camión";
            // 
            // tblCamiones
            // 
            this.tblCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMatricula,
            this.clmModelo,
            this.cblCapacidadKg,
            this.clmCapacidadM3});
            this.tblCamiones.Location = new System.Drawing.Point(80, 243);
            this.tblCamiones.Name = "tblCamiones";
            this.tblCamiones.Size = new System.Drawing.Size(444, 140);
            this.tblCamiones.TabIndex = 57;
            // 
            // clmMatricula
            // 
            this.clmMatricula.Frozen = true;
            this.clmMatricula.HeaderText = "Matricula";
            this.clmMatricula.Name = "clmMatricula";
            this.clmMatricula.ReadOnly = true;
            // 
            // clmModelo
            // 
            this.clmModelo.Frozen = true;
            this.clmModelo.HeaderText = "Modelo";
            this.clmModelo.Name = "clmModelo";
            this.clmModelo.ReadOnly = true;
            // 
            // cblCapacidadKg
            // 
            this.cblCapacidadKg.Frozen = true;
            this.cblCapacidadKg.HeaderText = "Capacidad (Kg)";
            this.cblCapacidadKg.Name = "cblCapacidadKg";
            this.cblCapacidadKg.ReadOnly = true;
            // 
            // clmCapacidadM3
            // 
            this.clmCapacidadM3.Frozen = true;
            this.clmCapacidadM3.HeaderText = "Capacidad (m3)";
            this.clmCapacidadM3.Name = "clmCapacidadM3";
            this.clmCapacidadM3.ReadOnly = true;
            // 
            // Camiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblCamiones);
            this.Controls.Add(this.txtConfirmarCamion);
            this.Controls.Add(this.cbxEliminarCamion);
            this.Controls.Add(this.pnlEliminarCamion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxAtributoCamion);
            this.Controls.Add(this.txtActualizacionCamion);
            this.Controls.Add(this.cbxModificarCamion);
            this.Controls.Add(this.pnlAplicarCamion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlCrearCamion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVolumenCamion);
            this.Controls.Add(this.txtCapacidadCamion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Camiones";
            this.Size = new System.Drawing.Size(612, 415);
            this.pnlCrearCamion.ResumeLayout(false);
            this.pnlCrearCamion.PerformLayout();
            this.pnlAplicarCamion.ResumeLayout(false);
            this.pnlAplicarCamion.PerformLayout();
            this.pnlEliminarCamion.ResumeLayout(false);
            this.pnlEliminarCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrearCamion;
        private System.Windows.Forms.Label lblCrearCamion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVolumenCamion;
        private System.Windows.Forms.TextBox txtCapacidadCamion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAtributoCamion;
        private System.Windows.Forms.TextBox txtActualizacionCamion;
        private System.Windows.Forms.ComboBox cbxModificarCamion;
        private System.Windows.Forms.Panel pnlAplicarCamion;
        private System.Windows.Forms.Label lblAplicarCamion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtConfirmarCamion;
        private System.Windows.Forms.ComboBox cbxEliminarCamion;
        private System.Windows.Forms.Panel pnlEliminarCamion;
        private System.Windows.Forms.Label lblEliminarCamion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tblCamiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cblCapacidadKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacidadM3;
    }
}
