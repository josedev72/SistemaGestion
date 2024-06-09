namespace SistemaGestionUI
{
    partial class FormUsuario
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
            btnAceptar = new Button();
            btnVolver = new Button();
            txtMail = new TextBox();
            label6 = new Label();
            txtContrasenia = new TextBox();
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(382, 237);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 35);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(144, 237);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 35);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(144, 185);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(108, 27);
            txtMail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 188);
            label6.Name = "label6";
            label6.Size = new Size(35, 18);
            label6.TabIndex = 8;
            label6.Text = "Mail";
            // 
            // txtContrasenia
            // 
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(144, 152);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(108, 27);
            txtContrasenia.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 155);
            label5.Name = "label5";
            label5.Size = new Size(85, 18);
            label5.TabIndex = 9;
            label5.Text = "Contraseña";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreUsuario.Location = new Point(144, 117);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(108, 27);
            txtNombreUsuario.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 122);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 10;
            label4.Text = "Nombre Usuario";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(144, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(108, 27);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(144, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(369, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 54);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(144, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(108, 27);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(19, 18);
            label1.TabIndex = 6;
            label1.Text = "Id";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 297);
            Controls.Add(btnAceptar);
            Controls.Add(btnVolver);
            Controls.Add(txtMail);
            Controls.Add(label6);
            Controls.Add(txtContrasenia);
            Controls.Add(label5);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            Load += FormUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnVolver;
        private TextBox txtMail;
        private Label label6;
        private TextBox txtContrasenia;
        private Label label5;
        private TextBox txtNombreUsuario;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}