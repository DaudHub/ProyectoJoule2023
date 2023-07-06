namespace CRUD
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            pbxVer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVer).BeginInit();
            SuspendLayout();
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(138, 253);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 23;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(109, 216);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 250);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 17;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 213);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 14;
            label2.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(92, 361);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 42);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 87);
            panel1.TabIndex = 13;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSalmon;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(60, 37);
            button5.TabIndex = 32;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(526, 0);
            button3.Name = "button3";
            button3.Size = new Size(34, 21);
            button3.TabIndex = 26;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.ForeColor = Color.White;
            button2.Location = new Point(566, 0);
            button2.Name = "button2";
            button2.Size = new Size(34, 21);
            button2.TabIndex = 25;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(181, 21);
            label1.Name = "label1";
            label1.Size = new Size(249, 38);
            label1.TabIndex = 1;
            label1.Text = "ELIMINAR USUARIO";
            // 
            // pbxVer
            // 
            pbxVer.Image = (Image)resources.GetObject("pbxVer.Image");
            pbxVer.Location = new Point(244, 242);
            pbxVer.Name = "pbxVer";
            pbxVer.Size = new Size(49, 48);
            pbxVer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxVer.TabIndex = 24;
            pbxVer.TabStop = false;
            pbxVer.Click += pbxVer_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 427);
            ControlBox = false;
            Controls.Add(pbxVer);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(panel1);
            Name = "DeleteUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Panel panel1;
        private Label label1;
        private PictureBox pbxVer;
        private Button button3;
        private Button button2;
        private Button button5;
    }
}