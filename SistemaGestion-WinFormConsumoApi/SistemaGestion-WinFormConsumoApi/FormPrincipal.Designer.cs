namespace SistemaGestion_WinFormConsumoApi
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            cmbTablas = new ComboBox();
            btnNuevo = new Button();
            btnBorrar = new Button();
            dgvDatos = new DataGridView();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 38);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Selecc. Tabla:";
            // 
            // cmbTablas
            // 
            cmbTablas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTablas.FormattingEnabled = true;
            cmbTablas.Location = new Point(110, 35);
            cmbTablas.Name = "cmbTablas";
            cmbTablas.Size = new Size(219, 28);
            cmbTablas.TabIndex = 6;
            cmbTablas.SelectedIndexChanged += cmbTablas_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(353, 35);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(108, 28);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(467, 34);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(108, 28);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(8, 72);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(780, 246);
            dgvDatos.TabIndex = 9;
            dgvDatos.CellClick += dgvDatos_CellClick;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;
            // 
            // lblUsuario
            // 
            lblUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario.Dock = DockStyle.Bottom;
            lblUsuario.FlatStyle = FlatStyle.Flat;
            lblUsuario.Location = new Point(0, 352);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(800, 23);
            lblUsuario.TabIndex = 11;
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 375);
            Controls.Add(lblUsuario);
            Controls.Add(dgvDatos);
            Controls.Add(btnBorrar);
            Controls.Add(btnNuevo);
            Controls.Add(cmbTablas);
            Controls.Add(label2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SistemaGestion - Consumo de Api";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmbTablas;
        private Button btnNuevo;
        private Button btnBorrar;
        private DataGridView dgvDatos;
        private Label lblUsuario;
    }
}
