﻿namespace SistemaGestionUI
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
            txtIdUsuario = new TextBox();
            label6 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtPrecioVenta = new TextBox();
            label4 = new Label();
            txtCosto = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
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
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(144, 237);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 35);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtIdUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(144, 185);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(108, 27);
            txtIdUsuario.TabIndex = 13;
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
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(144, 152);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(108, 27);
            txtStock.TabIndex = 14;
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
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.Location = new Point(144, 117);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(108, 27);
            txtPrecioVenta.TabIndex = 15;
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
            // txtCosto
            // 
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(144, 84);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(108, 27);
            txtCosto.TabIndex = 16;
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
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(144, 51);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(369, 27);
            txtDescripcion.TabIndex = 17;
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
            txtId.TabIndex = 7;
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
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label4);
            Controls.Add(txtCosto);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnVolver;
        private TextBox txtIdUsuario;
        private Label label6;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtPrecioVenta;
        private Label label4;
        private TextBox txtCosto;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}