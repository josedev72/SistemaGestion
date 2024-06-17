namespace SistemaGestion_WinFormConsumoApi.FormsSecundarios
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnAceptar = new Button();
            btnVolver = new Button();
            txtIdUsuario = new TextBox();
            label6 = new Label();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            label7 = new Label();
            txtCosto = new TextBox();
            txtDescripcion = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 124);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 29;
            label5.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 30;
            label3.Text = "Costo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 31;
            label2.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(19, 18);
            label4.TabIndex = 28;
            label4.Text = "Id";
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(377, 176);
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
            btnVolver.Location = new Point(116, 176);
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
            txtIdUsuario.Location = new Point(377, 120);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(108, 27);
            txtIdUsuario.TabIndex = 5;
            txtIdUsuario.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(276, 127);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 40;
            label6.Text = "Id Usuario";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(116, 120);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(108, 27);
            txtStock.TabIndex = 4;
            txtStock.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.Location = new Point(377, 87);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(108, 27);
            txtPrecioVenta.TabIndex = 3;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(276, 94);
            label7.Name = "label7";
            label7.Size = new Size(92, 18);
            label7.TabIndex = 41;
            label7.Text = "Precio Venta";
            // 
            // txtCosto
            // 
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(116, 87);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(108, 27);
            txtCosto.TabIndex = 2;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(116, 54);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(369, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(116, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(108, 27);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Right;
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
            Controls.Add(txtPrecioVenta);
            Controls.Add(label7);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            Load += FormProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnAceptar;
        private Button btnVolver;
        private TextBox txtIdUsuario;
        private Label label6;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private Label label7;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
        private TextBox txtId;
    }
}