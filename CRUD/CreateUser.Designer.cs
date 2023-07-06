namespace CRUD
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            panel1 = new Panel();
            btnVolver = new Button();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUsuario = new TextBox();
            cbxRol = new ComboBox();
            txtContrasena = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            pbxVer = new PictureBox();
            btnCrear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 87);
            panel1.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSalmon;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(60, 37);
            btnVolver.TabIndex = 32;
            btnVolver.Text = "←";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Yellow;
            btnMinimizar.Location = new Point(523, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(34, 21);
            btnMinimizar.TabIndex = 18;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(563, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(34, 21);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(192, 22);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 1;
            label1.Text = "CREAR USUARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(307, 154);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(307, 191);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(307, 229);
            label4.Name = "label4";
            label4.Size = new Size(41, 26);
            label4.TabIndex = 5;
            label4.Text = "Rol:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(307, 264);
            label5.Name = "label5";
            label5.Size = new Size(85, 26);
            label5.TabIndex = 6;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(307, 300);
            label6.Name = "label6";
            label6.Size = new Size(83, 26);
            label6.TabIndex = 7;
            label6.Text = "Apellido:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(393, 157);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 8;
            // 
            // cbxRol
            // 
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRol.FormattingEnabled = true;
            cbxRol.Items.AddRange(new object[] { "admin", "almacenero", "camionero", "cliente" });
            cbxRol.Location = new Point(354, 232);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(121, 23);
            cbxRol.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(422, 194);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 10;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(393, 267);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(393, 303);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 12;
            // 
            // pbxVer
            // 
            pbxVer.Image = (Image)resources.GetObject("pbxVer.Image");
            pbxVer.Location = new Point(528, 184);
            pbxVer.Name = "pbxVer";
            pbxVer.Size = new Size(47, 40);
            pbxVer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxVer.TabIndex = 13;
            pbxVer.TabStop = false;
            pbxVer.Click += pbxVer_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(382, 361);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(93, 42);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 427);
            ControlBox = false;
            Controls.Add(btnCrear);
            Controls.Add(pbxVer);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtContrasena);
            Controls.Add(cbxRol);
            Controls.Add(txtUsuario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "CreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CREAR";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUsuario;
        private ComboBox cbxRol;
        private TextBox txtContrasena;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private PictureBox pbxVer;
        private Button btnCrear;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Button btnVolver;
    }
}