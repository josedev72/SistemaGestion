using SistemaGestionBussiness;
using SistemaGestionData;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaGestionUI
{
    public partial class Form1 : Form
    {
        private int Id;
        private string tabla;

        public void cargoProductos()
        {
            dgvDatos.AutoGenerateColumns = true;
            dgvDatos.DataSource = ProductoBussiness.ListarProductos();
        }

        public void cargoProductosVendidos()
        {
            dgvDatos.AutoGenerateColumns = true;
            dgvDatos.DataSource = ProductoVendidoBussiness.ListarProductosVendidos();
        }

        public void cargoUsuarios()
        {
            dgvDatos.AutoGenerateColumns = true;
            dgvDatos.DataSource = UsuarioBussiness.ListarUsuarios();
        }

        public void cargoVentas()
        {
            dgvDatos.AutoGenerateColumns = true;
            dgvDatos.DataSource = VentaBussiness.ListarVentas();
        }

        public void cargarTablas()
        {
            cmbTablas.DataSource = TablasBussiness.GetTablas();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarTablas();

            cargoProductos();

            FormatearDgvDatos();
        }

        private void FormatearDgvDatos()
        {
            // Encabezado
            dgvDatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Autoajustar ancho de columna
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            // Asignar el estilo de celda para todo el DataGridView
            dgvDatos.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            //Barra
            dgvDatos.ScrollBars = ScrollBars.Vertical;

            // +/- filas
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;

            // Alinear a derecha si es N° y ocultar si es "Contrasenia"
            foreach (DataGridViewColumn columna in dgvDatos.Columns)
            {
                // Alinear
                if (columna.ValueType == typeof(int) || columna.ValueType == typeof(decimal) || columna.ValueType == typeof(double))
                {
                    columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Ver si encabezado es "Contrasenia"
                if (columna.HeaderText.Equals("Contrasenia"))
                {
                    columna.Visible = false;
                }
            }
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreTabla = cmbTablas.Text.Trim();

            switch (nombreTabla)
            {
                case "Producto":
                    cargoProductos();
                    break;

                case "ProductoVendido":
                    cargoProductosVendidos();
                    break;

                case "Usuario":
                    cargoUsuarios();
                    break;

                case "Venta":
                    cargoVentas();
                    break;


                default:
                    break;
            }

            FormatearDgvDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AbrirForm(0);
        }

        private void AbrirForm(int id)
        {
            switch (cmbTablas.Text)
            {
                case "Producto":
                    FormProducto fprod = new FormProducto(id);
                    fprod.FormClosed += FormProducto_FormClosed;
                    fprod.ShowDialog();
                    break;

                case "ProductoVendido":
                    FormProductoVendido fprodVendido = new FormProductoVendido(id);
                    fprodVendido.FormClosed += FormProductoVendido_FormClosed;
                    fprodVendido.ShowDialog();
                    break;

                case "Usuario":
                    FormUsuario fUsuario = new FormUsuario(id);
                    fUsuario.FormClosed += FormUsuario_FormClosed;
                    fUsuario.ShowDialog();
                    break;

                case "Venta":
                    FormVenta fVenta = new FormVenta(id);
                    fVenta.FormClosed += FormVenta_FormClosed;
                    fVenta.ShowDialog();
                    break;

                default:
                    break;
            }
        }

        private void FormProducto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Producto");
        }

        private void FormProductoVendido_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("ProductoVendido");
        }

        private void FormUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Usuario");
        }

        private void FormVenta_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Venta");
        }

        private void TraerTabla(string nombreTabla)
        {
            switch (nombreTabla)
            {
                case "Producto":
                    cargoProductos();
                    break;

                case "ProductoVendido":
                    cargoProductosVendidos();
                    break;

                case "Usuario":
                    cargoUsuarios();
                    break;

                case "Venta":
                    cargoVentas();
                    break;
                default:
                    break;
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDatos.Rows[e.RowIndex];

                AbrirForm(selectedRow, cmbTablas.Text);
            }
        }

        private void AbrirForm(DataGridViewRow fila, string tabla)
        {
            // Extraer datos de la fila seleccionada
            int id = Convert.ToInt32(fila.Cells[0].Value);

            switch (tabla)
            {
                case "Producto":
                    FormProducto formProducto = new FormProducto(id);
                    formProducto.FormClosed += FormProducto_FormClosed;
                    formProducto.ShowDialog();
                    break;

                case "ProductoVendido":
                    FormProductoVendido formProductoVendido = new FormProductoVendido(id);
                    formProductoVendido.FormClosed += FormProductoVendido_FormClosed;
                    formProductoVendido.ShowDialog();
                    break;

                case "Usuario":
                    FormUsuario formUsuario = new FormUsuario(id);
                    formUsuario.FormClosed += FormUsuario_FormClosed;
                    formUsuario.ShowDialog();
                    break;

                case "Venta":
                    FormVenta formVenta = new FormVenta(id);
                    formVenta.FormClosed += FormVenta_FormClosed;
                    formVenta.ShowDialog();
                    break;

                default:
                    Console.WriteLine("Tabla no encontrada");
                    break;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tabla) && this.Id >0 )
            {
                switch (this.tabla)
                {
                    case "Producto":
                        ProductoBussiness.EliminarProductoId(this.Id);
                        cargoProductos();
                        break;

                    case "ProductoVendido":
                        ProductoVendidoBussiness.EliminarProductoVendidoId(this.Id);
                        cargoProductosVendidos();
                        break;

                    case "Usuario":
                        UsuarioBussiness.EliminarUsuarioId(this.Id);
                        cargoUsuarios();
                        break;

                    case "Venta":
                        VentaBussiness.EliminarVentaId(this.Id);
                        cargoVentas();
                        break;

                    default:
                        MessageBox.Show("Tabla no encontrada","Advertencia . . .",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private void dgvDatos_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDatos.Rows[e.RowIndex];

                // Acceder a la fila seleccionada
                this.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                this.tabla = cmbTablas.Text.Trim();
            }
        }
    }
}
