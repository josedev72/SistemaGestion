namespace SistemaGestionUI
{
    partial class FormProducto
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
            btnAceptar.Location = new Point(382, 173);
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
            btnVolver.Location = new Point(121, 173);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 35);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtIdUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(382, 117);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(108, 27);
            txtIdUsuario.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(281, 124);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 22;
            label6.Text = "Id Usuario";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(121, 117);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(108, 27);
            txtStock.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 124);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 23;
            label5.Text = "Stock";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.Location = new Point(382, 84);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(108, 27);
            txtPrecioVenta.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(281, 91);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 24;
            label4.Text = "Precio Venta";
            // 
            // txtCosto
            // 
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(121, 84);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(108, 27);
            txtCosto.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 91);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 26;
            label3.Text = "Costo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(121, 51);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(369, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 27;
            label2.Text = "Descripción";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(121, 18);
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
            label1.TabIndex = 20;
            label1.Text = "Id";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 238);
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
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            Load += FormProducto2_Load;
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