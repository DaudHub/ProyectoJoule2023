namespace CRUD
{
    partial class Home
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
            panel1 = new Panel();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            btnUsuarios = new Button();
            btnAlmacenes = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 87);
            panel1.TabIndex = 7;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Yellow;
            btnMinimizar.Location = new Point(775, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(34, 21);
            btnMinimizar.TabIndex = 28;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(815, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(34, 21);
            btnCerrar.TabIndex = 27;
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
            label1.Location = new Point(346, 25);
            label1.Name = "label1";
            label1.Size = new Size(174, 38);
            label1.TabIndex = 1;
            label1.Text = "BACK OFFICE";
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(45, 133);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(164, 68);
            btnUsuarios.TabIndex = 8;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAlmacenes
            // 
            btnAlmacenes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlmacenes.Location = new Point(235, 133);
            btnAlmacenes.Name = "btnAlmacenes";
            btnAlmacenes.Size = new Size(165, 68);
            btnAlmacenes.TabIndex = 9;
            btnAlmacenes.Text = "Almacenes";
            btnAlmacenes.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 487);
            ControlBox = false;
            Controls.Add(btnAlmacenes);
            Controls.Add(btnUsuarios);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Label label1;
        private Button btnUsuarios;
        private Button btnAlmacenes;
    }
}