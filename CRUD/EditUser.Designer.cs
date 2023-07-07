namespace CRUD
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtContrasena = new TextBox();
            txtUsuarioNuevo = new TextBox();
            txtUsuarioViejo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnModificarUsuario = new Button();
            panel3 = new Panel();
            txtContrasenaNueva = new TextBox();
            label3 = new Label();
            txtContrasenaVieja = new TextBox();
            btnModificarContrasena = new Button();
            txtUsuario = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 87);
            panel1.TabIndex = 25;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSalmon;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(60, 37);
            button5.TabIndex = 31;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(524, 0);
            button3.Name = "button3";
            button3.Size = new Size(34, 21);
            button3.TabIndex = 30;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.ForeColor = Color.White;
            button4.Location = new Point(564, 0);
            button4.Name = "button4";
            button4.Size = new Size(34, 21);
            button4.TabIndex = 29;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 22);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 1;
            label1.Text = "MODIFICAR USUARIO";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(txtUsuarioNuevo);
            panel2.Controls.Add(txtUsuarioViejo);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnModificarUsuario);
            panel2.Location = new Point(27, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 165);
            panel2.TabIndex = 26;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(150, 97);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 31;
            // 
            // txtUsuarioNuevo
            // 
            txtUsuarioNuevo.Location = new Point(150, 63);
            txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            txtUsuarioNuevo.Size = new Size(100, 23);
            txtUsuarioNuevo.TabIndex = 30;
            // 
            // txtUsuarioViejo
            // 
            txtUsuarioViejo.Location = new Point(150, 34);
            txtUsuarioViejo.Name = "txtUsuarioViejo";
            txtUsuarioViejo.Size = new Size(100, 23);
            txtUsuarioViejo.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 97);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 18;
            label6.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(13, 66);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 17;
            label5.Text = "USUARIO NUEVO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 37);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 16;
            label4.Text = "USUARIO ACTUAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 15;
            label2.Text = "CAMBIAR USUARIO";
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(243, 139);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(83, 23);
            btnModificarUsuario.TabIndex = 0;
            btnModificarUsuario.Text = "MODIFICAR";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtContrasenaNueva);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtContrasenaVieja);
            panel3.Controls.Add(btnModificarContrasena);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(27, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 149);
            panel3.TabIndex = 27;
            // 
            // txtContrasenaNueva
            // 
            txtContrasenaNueva.Location = new Point(182, 85);
            txtContrasenaNueva.Name = "txtContrasenaNueva";
            txtContrasenaNueva.Size = new Size(100, 23);
            txtContrasenaNueva.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 16;
            label3.Text = "CAMBIAR CONTRASEÑA";
            // 
            // txtContrasenaVieja
            // 
            txtContrasenaVieja.Location = new Point(182, 56);
            txtContrasenaVieja.Name = "txtContrasenaVieja";
            txtContrasenaVieja.Size = new Size(100, 23);
            txtContrasenaVieja.TabIndex = 36;
            // 
            // btnModificarContrasena
            // 
            btnModificarContrasena.Location = new Point(243, 123);
            btnModificarContrasena.Name = "btnModificarContrasena";
            btnModificarContrasena.Size = new Size(83, 23);
            btnModificarContrasena.TabIndex = 1;
            btnModificarContrasena.Text = "MODIFICAR";
            btnModificarContrasena.UseVisualStyleBackColor = true;
            btnModificarContrasena.Click += btnModificarContrasena_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(182, 27);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(11, 59);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 33;
            label8.Text = "CONTRASEÑA ACTUAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(11, 86);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 34;
            label7.Text = "CONTRASEÑA NUEVA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(11, 30);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 32;
            label9.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(385, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 427);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnModificarUsuario;
        private Button btnModificarContrasena;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtContrasena;
        private TextBox txtUsuarioNuevo;
        private TextBox txtUsuarioViejo;
        private TextBox txtContrasenaNueva;
        private TextBox txtContrasenaVieja;
        private TextBox txtUsuario;
        private Label label8;
        private Label label7;
        private Label label9;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}