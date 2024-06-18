namespace SistemaGestion_WinFormConsumoApi
{
    partial class FormLoguin
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
            txtContrasenia = new TextBox();
            label5 = new Label();
            cmbUsuarios = new ComboBox();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(331, 133);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 35);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(177, 81);
            txtContrasenia.MaxLength = 15;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(262, 27);
            txtContrasenia.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 84);
            label5.Name = "label5";
            label5.Size = new Size(85, 18);
            label5.TabIndex = 26;
            label5.Text = "Contraseña";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(177, 36);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(262, 28);
            cmbUsuarios.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 39);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 27;
            label2.Text = "Selecc. Usuario:";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(177, 133);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 35);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormLoguin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 203);
            Controls.Add(btnCancelar);
            Controls.Add(cmbUsuarios);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(txtContrasenia);
            Controls.Add(label5);
            Name = "FormLoguin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "     Loguin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtContrasenia;
        private Label label5;
        private ComboBox cmbUsuarios;
        private Label label2;
        private Button btnCancelar;
    }
}