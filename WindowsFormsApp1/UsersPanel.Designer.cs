namespace WindowsFormsApp1
{
    partial class UsersPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCrearUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrearContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCrearRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrearNombre = new System.Windows.Forms.TextBox();
            this.txtCrearApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCrearUsuario = new System.Windows.Forms.Panel();
            this.lblCrearUsuario = new System.Windows.Forms.Label();
            this.pnlAplicar = new System.Windows.Forms.Panel();
            this.lblAplicar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxModificarUsuario = new System.Windows.Forms.ComboBox();
            this.txtActualizacion = new System.Windows.Forms.TextBox();
            this.cbxAtributo = new System.Windows.Forms.ComboBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.cbxEliminarUsuario = new System.Windows.Forms.ComboBox();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tblUsuarios = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCrearUsuario.SuspendLayout();
            this.pnlAplicar.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // txtCrearUsuario
            // 
            this.txtCrearUsuario.Location = new System.Drawing.Point(83, 54);
            this.txtCrearUsuario.Name = "txtCrearUsuario";
            this.txtCrearUsuario.Size = new System.Drawing.Size(104, 20);
            this.txtCrearUsuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // txtCrearContraseña
            // 
            this.txtCrearContraseña.Location = new System.Drawing.Point(103, 80);
            this.txtCrearContraseña.Name = "txtCrearContraseña";
            this.txtCrearContraseña.Size = new System.Drawing.Size(84, 20);
            this.txtCrearContraseña.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rol:";
            // 
            // cbxCrearRol
            // 
            this.cbxCrearRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCrearRol.FormattingEnabled = true;
            this.cbxCrearRol.Items.AddRange(new object[] {
            "administrador",
            "almacenero",
            "camionero",
            "cliente"});
            this.cbxCrearRol.Location = new System.Drawing.Point(58, 106);
            this.cbxCrearRol.Name = "cbxCrearRol";
            this.cbxCrearRol.Size = new System.Drawing.Size(129, 21);
            this.cbxCrearRol.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre:";
            // 
            // txtCrearNombre
            // 
            this.txtCrearNombre.Location = new System.Drawing.Point(85, 133);
            this.txtCrearNombre.Name = "txtCrearNombre";
            this.txtCrearNombre.Size = new System.Drawing.Size(102, 20);
            this.txtCrearNombre.TabIndex = 8;
            // 
            // txtCrearApellido
            // 
            this.txtCrearApellido.Location = new System.Drawing.Point(83, 161);
            this.txtCrearApellido.Name = "txtCrearApellido";
            this.txtCrearApellido.Size = new System.Drawing.Size(104, 20);
            this.txtCrearApellido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Apellido:";
            // 
            // pnlCrearUsuario
            // 
            this.pnlCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCrearUsuario.Controls.Add(this.lblCrearUsuario);
            this.pnlCrearUsuario.Location = new System.Drawing.Point(58, 197);
            this.pnlCrearUsuario.Name = "pnlCrearUsuario";
            this.pnlCrearUsuario.Size = new System.Drawing.Size(98, 22);
            this.pnlCrearUsuario.TabIndex = 11;
            this.pnlCrearUsuario.Click += new System.EventHandler(this.pnlCrearUsuario_Click);
            // 
            // lblCrearUsuario
            // 
            this.lblCrearUsuario.AutoSize = true;
            this.lblCrearUsuario.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.lblCrearUsuario.Location = new System.Drawing.Point(28, 2);
            this.lblCrearUsuario.Name = "lblCrearUsuario";
            this.lblCrearUsuario.Size = new System.Drawing.Size(40, 17);
            this.lblCrearUsuario.TabIndex = 12;
            this.lblCrearUsuario.Text = "Crear";
            this.lblCrearUsuario.Click += new System.EventHandler(this.lblCrearUsuario_Click);
            // 
            // pnlAplicar
            // 
            this.pnlAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAplicar.Controls.Add(this.lblAplicar);
            this.pnlAplicar.Location = new System.Drawing.Point(253, 145);
            this.pnlAplicar.Name = "pnlAplicar";
            this.pnlAplicar.Size = new System.Drawing.Size(98, 22);
            this.pnlAplicar.TabIndex = 24;
            this.pnlAplicar.Click += new System.EventHandler(this.pnlAplicar_Click);
            // 
            // lblAplicar
            // 
            this.lblAplicar.AutoSize = true;
            this.lblAplicar.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicar.ForeColor = System.Drawing.Color.White;
            this.lblAplicar.Location = new System.Drawing.Point(27, 2);
            this.lblAplicar.Name = "lblAplicar";
            this.lblAplicar.Size = new System.Drawing.Size(48, 17);
            this.lblAplicar.TabIndex = 12;
            this.lblAplicar.Text = "Aplicar";
            this.lblAplicar.Click += new System.EventHandler(this.lblAplicar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Actualización:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(223, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Atributo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(223, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(221, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 27);
            this.label13.TabIndex = 13;
            this.label13.Text = "Modificar Usuario";
            // 
            // cbxModificarUsuario
            // 
            this.cbxModificarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModificarUsuario.FormattingEnabled = true;
            this.cbxModificarUsuario.Location = new System.Drawing.Point(283, 57);
            this.cbxModificarUsuario.Name = "cbxModificarUsuario";
            this.cbxModificarUsuario.Size = new System.Drawing.Size(104, 21);
            this.cbxModificarUsuario.TabIndex = 25;
            this.cbxModificarUsuario.DropDown += new System.EventHandler(this.cbxModificarUsuario_DropDown);
            // 
            // txtActualizacion
            // 
            this.txtActualizacion.Location = new System.Drawing.Point(313, 111);
            this.txtActualizacion.Name = "txtActualizacion";
            this.txtActualizacion.Size = new System.Drawing.Size(74, 20);
            this.txtActualizacion.TabIndex = 26;
            // 
            // cbxAtributo
            // 
            this.cbxAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtributo.FormattingEnabled = true;
            this.cbxAtributo.Items.AddRange(new object[] {
            "contraseña",
            "rol",
            "nombre",
            "apellido"});
            this.cbxAtributo.Location = new System.Drawing.Point(283, 84);
            this.cbxAtributo.Name = "cbxAtributo";
            this.cbxAtributo.Size = new System.Drawing.Size(104, 21);
            this.cbxAtributo.TabIndex = 27;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(496, 86);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(91, 20);
            this.txtConfirmar.TabIndex = 34;
            // 
            // cbxEliminarUsuario
            // 
            this.cbxEliminarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEliminarUsuario.FormattingEnabled = true;
            this.cbxEliminarUsuario.Location = new System.Drawing.Point(483, 57);
            this.cbxEliminarUsuario.Name = "cbxEliminarUsuario";
            this.cbxEliminarUsuario.Size = new System.Drawing.Size(104, 21);
            this.cbxEliminarUsuario.TabIndex = 33;
            this.cbxEliminarUsuario.DropDown += new System.EventHandler(this.cbxEliminarUsuario_DropDown);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlEliminar.Controls.Add(this.lblEliminar);
            this.pnlEliminar.Location = new System.Drawing.Point(460, 119);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(98, 22);
            this.pnlEliminar.TabIndex = 32;
            this.pnlEliminar.Click += new System.EventHandler(this.pnlEliminar_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.White;
            this.lblEliminar.Location = new System.Drawing.Point(22, 2);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(57, 17);
            this.lblEliminar.TabIndex = 12;
            this.lblEliminar.Text = "Eliminar";
            this.lblEliminar.Click += new System.EventHandler(this.lblEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Confirmar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(423, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Usuario:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(421, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 27);
            this.label15.TabIndex = 28;
            this.label15.Text = "Eliminar Usuario";
            // 
            // tblUsuarios
            // 
            this.tblUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.rol,
            this.nombre,
            this.apellido});
            this.tblUsuarios.Location = new System.Drawing.Point(83, 249);
            this.tblUsuarios.Name = "tblUsuarios";
            this.tblUsuarios.Size = new System.Drawing.Size(444, 140);
            this.tblUsuarios.TabIndex = 36;
            // 
            // usuario
            // 
            this.usuario.Frozen = true;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rol
            // 
            this.rol.Frozen = true;
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // apellido
            // 
            this.apellido.Frozen = true;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UsersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblUsuarios);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.cbxEliminarUsuario);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxAtributo);
            this.Controls.Add(this.txtActualizacion);
            this.Controls.Add(this.cbxModificarUsuario);
            this.Controls.Add(this.pnlAplicar);
            this.Controls.Add(this.pnlCrearUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCrearApellido);
            this.Controls.Add(this.txtCrearNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxCrearRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCrearContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCrearUsuario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsersPanel";
            this.Size = new System.Drawing.Size(612, 415);
            this.pnlCrearUsuario.ResumeLayout(false);
            this.pnlCrearUsuario.PerformLayout();
            this.pnlAplicar.ResumeLayout(false);
            this.pnlAplicar.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCrearUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrearContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCrearRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCrearNombre;
        private System.Windows.Forms.TextBox txtCrearApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCrearUsuario;
        private System.Windows.Forms.Label lblCrearUsuario;
        private System.Windows.Forms.Panel pnlAplicar;
        private System.Windows.Forms.Label lblAplicar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxModificarUsuario;
        private System.Windows.Forms.TextBox txtActualizacion;
        private System.Windows.Forms.ComboBox cbxAtributo;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.ComboBox cbxEliminarUsuario;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tblUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}
