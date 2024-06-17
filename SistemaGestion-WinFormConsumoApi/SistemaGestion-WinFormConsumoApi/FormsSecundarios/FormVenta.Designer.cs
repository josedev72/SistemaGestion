namespace SistemaGestion_WinFormConsumoApi.FormsSecundarios
{
    partial class FormVenta
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
            txtIdUsuario = new TextBox();
            label3 = new Label();
            txtComentarios = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(277, 140);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 35);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(124, 140);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 35);
            btnVolver.TabIndex = 28;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtIdUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(124, 89);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(108, 27);
            txtIdUsuario.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 96);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 31;
            label3.Text = "Id. Usuario";
            // 
            // txtComentarios
            // 
            txtComentarios.BorderStyle = BorderStyle.FixedSingle;
            txtComentarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(124, 56);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(167, 27);
            txtComentarios.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 32;
            label2.Text = "Comentarios";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(124, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(108, 27);
            txtId.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 26);
            label4.Name = "label4";
            label4.Size = new Size(19, 18);
            label4.TabIndex = 30;
            label4.Text = "Id";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 199);
            Controls.Add(btnAceptar);
            Controls.Add(btnVolver);
            Controls.Add(txtIdUsuario);
            Controls.Add(label3);
            Controls.Add(txtComentarios);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label4);
            Name = "FormVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            Load += FormVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnVolver;
        private TextBox txtIdUsuario;
        private Label label3;
        private TextBox txtComentarios;
        private Label label2;
        private TextBox txtId;
        private Label label4;
    }
}