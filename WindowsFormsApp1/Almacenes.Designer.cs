namespace WindowsFormsApp1
{
    partial class Almacenes
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
            this.pnlCrearAlmacen = new System.Windows.Forms.Panel();
            this.lblCrearAlmacen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroPuerta = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCapacidadKg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCapacidadm3 = new System.Windows.Forms.TextBox();
            this.txtConfirmarAlmacen = new System.Windows.Forms.TextBox();
            this.cbxEliminarAlmacen = new System.Windows.Forms.ComboBox();
            this.pnlEliminarAlmacen = new System.Windows.Forms.Panel();
            this.lblEliminarAlmacen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxAtributoAlmacen = new System.Windows.Forms.ComboBox();
            this.txtActualizacionAlmacen = new System.Windows.Forms.TextBox();
            this.cbxModificarAlmacen = new System.Windows.Forms.ComboBox();
            this.pnlAplicarAlmacen = new System.Windows.Forms.Panel();
            this.lblAplicarAlmacen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tblAlmacenes = new System.Windows.Forms.DataGridView();
            this.clmIDAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLatitudAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLongitudAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumeroPuerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacidadKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacidadM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCrearAlmacen.SuspendLayout();
            this.pnlEliminarAlmacen.SuspendLayout();
            this.pnlAplicarAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlmacenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCrearAlmacen
            // 
            this.pnlCrearAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCrearAlmacen.Controls.Add(this.lblCrearAlmacen);
            this.pnlCrearAlmacen.Location = new System.Drawing.Point(50, 244);
            this.pnlCrearAlmacen.Name = "pnlCrearAlmacen";
            this.pnlCrearAlmacen.Size = new System.Drawing.Size(98, 22);
            this.pnlCrearAlmacen.TabIndex = 23;
            this.pnlCrearAlmacen.Click += new System.EventHandler(this.pnlCrearAlmacen_Click);
            // 
            // lblCrearAlmacen
            // 
            this.lblCrearAlmacen.AutoSize = true;
            this.lblCrearAlmacen.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearAlmacen.ForeColor = System.Drawing.Color.White;
            this.lblCrearAlmacen.Location = new System.Drawing.Point(28, 2);
            this.lblCrearAlmacen.Name = "lblCrearAlmacen";
            this.lblCrearAlmacen.Size = new System.Drawing.Size(40, 17);
            this.lblCrearAlmacen.TabIndex = 12;
            this.lblCrearAlmacen.Text = "Crear";
            this.lblCrearAlmacen.Click += new System.EventHandler(this.lblCrearAlmacen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "N° puerta:";
            // 
            // txtNumeroPuerta
            // 
            this.txtNumeroPuerta.Location = new System.Drawing.Point(85, 158);
            this.txtNumeroPuerta.Name = "txtNumeroPuerta";
            this.txtNumeroPuerta.Size = new System.Drawing.Size(98, 20);
            this.txtNumeroPuerta.TabIndex = 21;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(63, 132);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(120, 20);
            this.txtCalle.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Calle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Longitud:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(75, 80);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(108, 20);
            this.txtLatitud.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Latitud:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(135, 20);
            this.txtID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Crear Almacén";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(85, 106);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(98, 20);
            this.txtLongitud.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Capacidad(Kg):";
            // 
            // txtCapacidadKg
            // 
            this.txtCapacidadKg.Location = new System.Drawing.Point(118, 184);
            this.txtCapacidadKg.Name = "txtCapacidadKg";
            this.txtCapacidadKg.Size = new System.Drawing.Size(65, 20);
            this.txtCapacidadKg.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Capacidad(m3)";
            // 
            // txtCapacidadm3
            // 
            this.txtCapacidadm3.Location = new System.Drawing.Point(117, 210);
            this.txtCapacidadm3.Name = "txtCapacidadm3";
            this.txtCapacidadm3.Size = new System.Drawing.Size(66, 20);
            this.txtCapacidadm3.TabIndex = 27;
            // 
            // txtConfirmarAlmacen
            // 
            this.txtConfirmarAlmacen.Location = new System.Drawing.Point(491, 86);
            this.txtConfirmarAlmacen.Name = "txtConfirmarAlmacen";
            this.txtConfirmarAlmacen.Size = new System.Drawing.Size(91, 20);
            this.txtConfirmarAlmacen.TabIndex = 48;
            // 
            // cbxEliminarAlmacen
            // 
            this.cbxEliminarAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEliminarAlmacen.FormattingEnabled = true;
            this.cbxEliminarAlmacen.Location = new System.Drawing.Point(482, 57);
            this.cbxEliminarAlmacen.Name = "cbxEliminarAlmacen";
            this.cbxEliminarAlmacen.Size = new System.Drawing.Size(100, 21);
            this.cbxEliminarAlmacen.TabIndex = 47;
            this.cbxEliminarAlmacen.DropDown += new System.EventHandler(this.cbxEliminarAlmacen_DropDown);
            // 
            // pnlEliminarAlmacen
            // 
            this.pnlEliminarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlEliminarAlmacen.Controls.Add(this.lblEliminarAlmacen);
            this.pnlEliminarAlmacen.Location = new System.Drawing.Point(455, 119);
            this.pnlEliminarAlmacen.Name = "pnlEliminarAlmacen";
            this.pnlEliminarAlmacen.Size = new System.Drawing.Size(98, 22);
            this.pnlEliminarAlmacen.TabIndex = 46;
            this.pnlEliminarAlmacen.Click += new System.EventHandler(this.pnlEliminarAlmacen_Click);
            // 
            // lblEliminarAlmacen
            // 
            this.lblEliminarAlmacen.AutoSize = true;
            this.lblEliminarAlmacen.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarAlmacen.ForeColor = System.Drawing.Color.White;
            this.lblEliminarAlmacen.Location = new System.Drawing.Point(22, 2);
            this.lblEliminarAlmacen.Name = "lblEliminarAlmacen";
            this.lblEliminarAlmacen.Size = new System.Drawing.Size(57, 17);
            this.lblEliminarAlmacen.TabIndex = 12;
            this.lblEliminarAlmacen.Text = "Eliminar";
            this.lblEliminarAlmacen.Click += new System.EventHandler(this.lblEliminarAlmacen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Confirmar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(418, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Almacén:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(416, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 27);
            this.label15.TabIndex = 43;
            this.label15.Text = "Eliminar Almacén";
            // 
            // cbxAtributoAlmacen
            // 
            this.cbxAtributoAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtributoAlmacen.FormattingEnabled = true;
            this.cbxAtributoAlmacen.Items.AddRange(new object[] {
            "latitud",
            "longitud",
            "calle",
            "n°puerta",
            "capacidad(Kg)",
            "capacidad(m3)"});
            this.cbxAtributoAlmacen.Location = new System.Drawing.Point(278, 84);
            this.cbxAtributoAlmacen.Name = "cbxAtributoAlmacen";
            this.cbxAtributoAlmacen.Size = new System.Drawing.Size(104, 21);
            this.cbxAtributoAlmacen.TabIndex = 42;
            // 
            // txtActualizacionAlmacen
            // 
            this.txtActualizacionAlmacen.Location = new System.Drawing.Point(308, 111);
            this.txtActualizacionAlmacen.Name = "txtActualizacionAlmacen";
            this.txtActualizacionAlmacen.Size = new System.Drawing.Size(74, 20);
            this.txtActualizacionAlmacen.TabIndex = 41;
            // 
            // cbxModificarAlmacen
            // 
            this.cbxModificarAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModificarAlmacen.FormattingEnabled = true;
            this.cbxModificarAlmacen.Location = new System.Drawing.Point(282, 57);
            this.cbxModificarAlmacen.Name = "cbxModificarAlmacen";
            this.cbxModificarAlmacen.Size = new System.Drawing.Size(100, 21);
            this.cbxModificarAlmacen.TabIndex = 40;
            this.cbxModificarAlmacen.DropDown += new System.EventHandler(this.cbxModificarAlmacen_DropDown);
            // 
            // pnlAplicarAlmacen
            // 
            this.pnlAplicarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAplicarAlmacen.Controls.Add(this.lblAplicarAlmacen);
            this.pnlAplicarAlmacen.Location = new System.Drawing.Point(248, 145);
            this.pnlAplicarAlmacen.Name = "pnlAplicarAlmacen";
            this.pnlAplicarAlmacen.Size = new System.Drawing.Size(98, 22);
            this.pnlAplicarAlmacen.TabIndex = 39;
            this.pnlAplicarAlmacen.Click += new System.EventHandler(this.pnlAplicarAlmacen_Click);
            // 
            // lblAplicarAlmacen
            // 
            this.lblAplicarAlmacen.AutoSize = true;
            this.lblAplicarAlmacen.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicarAlmacen.ForeColor = System.Drawing.Color.White;
            this.lblAplicarAlmacen.Location = new System.Drawing.Point(27, 2);
            this.lblAplicarAlmacen.Name = "lblAplicarAlmacen";
            this.lblAplicarAlmacen.Size = new System.Drawing.Size(48, 17);
            this.lblAplicarAlmacen.TabIndex = 12;
            this.lblAplicarAlmacen.Text = "Aplicar";
            this.lblAplicarAlmacen.Click += new System.EventHandler(this.lblAplicarAlmacen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Actualización:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Atributo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(218, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Almacén:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(216, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 27);
            this.label13.TabIndex = 35;
            this.label13.Text = "Modificar Almacén";
            // 
            // tblAlmacenes
            // 
            this.tblAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tblAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAlmacenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDAlmacen,
            this.clmLatitudAlmacen,
            this.clmLongitudAlmacen,
            this.clmCalle,
            this.clmNumeroPuerta,
            this.clmCapacidadKg,
            this.clmCapacidadM3});
            this.tblAlmacenes.Location = new System.Drawing.Point(33, 282);
            this.tblAlmacenes.Name = "tblAlmacenes";
            this.tblAlmacenes.Size = new System.Drawing.Size(549, 116);
            this.tblAlmacenes.TabIndex = 49;
            // 
            // clmIDAlmacen
            // 
            this.clmIDAlmacen.Frozen = true;
            this.clmIDAlmacen.HeaderText = "ID";
            this.clmIDAlmacen.Name = "clmIDAlmacen";
            this.clmIDAlmacen.ReadOnly = true;
            this.clmIDAlmacen.Width = 43;
            // 
            // clmLatitudAlmacen
            // 
            this.clmLatitudAlmacen.Frozen = true;
            this.clmLatitudAlmacen.HeaderText = "Latitud";
            this.clmLatitudAlmacen.Name = "clmLatitudAlmacen";
            this.clmLatitudAlmacen.ReadOnly = true;
            this.clmLatitudAlmacen.Width = 64;
            // 
            // clmLongitudAlmacen
            // 
            this.clmLongitudAlmacen.Frozen = true;
            this.clmLongitudAlmacen.HeaderText = "Longitud";
            this.clmLongitudAlmacen.Name = "clmLongitudAlmacen";
            this.clmLongitudAlmacen.ReadOnly = true;
            this.clmLongitudAlmacen.Width = 73;
            // 
            // clmCalle
            // 
            this.clmCalle.Frozen = true;
            this.clmCalle.HeaderText = "Calle";
            this.clmCalle.Name = "clmCalle";
            this.clmCalle.ReadOnly = true;
            this.clmCalle.Width = 55;
            // 
            // clmNumeroPuerta
            // 
            this.clmNumeroPuerta.Frozen = true;
            this.clmNumeroPuerta.HeaderText = "N° Puerta";
            this.clmNumeroPuerta.Name = "clmNumeroPuerta";
            this.clmNumeroPuerta.ReadOnly = true;
            this.clmNumeroPuerta.Width = 72;
            // 
            // clmCapacidadKg
            // 
            this.clmCapacidadKg.Frozen = true;
            this.clmCapacidadKg.HeaderText = "Capacidad(Kg)";
            this.clmCapacidadKg.Name = "clmCapacidadKg";
            this.clmCapacidadKg.ReadOnly = true;
            this.clmCapacidadKg.Width = 102;
            // 
            // clmCapacidadM3
            // 
            this.clmCapacidadM3.Frozen = true;
            this.clmCapacidadM3.HeaderText = "Capacidad (m3)";
            this.clmCapacidadM3.Name = "clmCapacidadM3";
            this.clmCapacidadM3.ReadOnly = true;
            this.clmCapacidadM3.Width = 97;
            // 
            // Almacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblAlmacenes);
            this.Controls.Add(this.txtConfirmarAlmacen);
            this.Controls.Add(this.cbxEliminarAlmacen);
            this.Controls.Add(this.pnlEliminarAlmacen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxAtributoAlmacen);
            this.Controls.Add(this.txtActualizacionAlmacen);
            this.Controls.Add(this.cbxModificarAlmacen);
            this.Controls.Add(this.pnlAplicarAlmacen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCapacidadm3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCapacidadKg);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.pnlCrearAlmacen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroPuerta);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Almacenes";
            this.Size = new System.Drawing.Size(612, 415);
            this.pnlCrearAlmacen.ResumeLayout(false);
            this.pnlCrearAlmacen.PerformLayout();
            this.pnlEliminarAlmacen.ResumeLayout(false);
            this.pnlEliminarAlmacen.PerformLayout();
            this.pnlAplicarAlmacen.ResumeLayout(false);
            this.pnlAplicarAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlmacenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrearAlmacen;
        private System.Windows.Forms.Label lblCrearAlmacen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroPuerta;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCapacidadKg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCapacidadm3;
        private System.Windows.Forms.TextBox txtConfirmarAlmacen;
        private System.Windows.Forms.ComboBox cbxEliminarAlmacen;
        private System.Windows.Forms.Panel pnlEliminarAlmacen;
        private System.Windows.Forms.Label lblEliminarAlmacen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxAtributoAlmacen;
        private System.Windows.Forms.TextBox txtActualizacionAlmacen;
        private System.Windows.Forms.ComboBox cbxModificarAlmacen;
        private System.Windows.Forms.Panel pnlAplicarAlmacen;
        private System.Windows.Forms.Label lblAplicarAlmacen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView tblAlmacenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLatitudAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLongitudAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroPuerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacidadKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacidadM3;
    }
}
