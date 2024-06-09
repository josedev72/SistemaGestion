namespace SistemaGestionUI
{
    partial class FormProductoVendido
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
            txtIdVenta = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            txtIdProducto = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(284, 172);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 35);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(121, 172);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 35);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtIdVenta
            // 
            txtIdVenta.BorderStyle = BorderStyle.FixedSingle;
            txtIdVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdVenta.Location = new Point(121, 116);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(108, 27);
            txtIdVenta.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 123);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 20;
            label4.Text = "Id. Venta";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(121, 83);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(108, 27);
            txtStock.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 21;
            label3.Text = "Stock";
            // 
            // txtIdProducto
            // 
            txtIdProducto.BorderStyle = BorderStyle.FixedSingle;
            txtIdProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdProducto.Location = new Point(121, 50);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(167, 27);
            txtIdProducto.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 57);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 22;
            label2.Text = "Id. Producto";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(121, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(108, 27);
            txtId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(19, 18);
            label1.TabIndex = 19;
            label1.Text = "Id";
            // 
            // FormProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 225);
            Controls.Add(btnAceptar);
            Controls.Add(btnVolver);
            Controls.Add(txtIdVenta);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtIdProducto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormProductoVendido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto Vendido";
            Load += FormProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnVolver;
        private TextBox txtIdVenta;
        private Label label4;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtIdProducto;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}