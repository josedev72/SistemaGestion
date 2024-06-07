using SistemaGestionBussiness;
using SistemaGestionData;
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

        private void FormVenta_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Venta");
        }

        private void FormUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Usuario");
        }

        private void FormProductoVendido_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("ProductoVendido");
        }

        private void FormProducto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Producto");
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
                    formProductoVendido.ShowDialog();
                    break;

                case "Usuario":
                    FormUsuario formUsuario = new FormUsuario(id);
                    formUsuario.ShowDialog();
                    break;

                case "Venta":
                    FormVenta formVenta = new FormVenta(id);
                    formVenta.ShowDialog();
                    break;
                default:
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
                        ProductoBussiness.EliminarProductoId(this.Id);
                        cargoProductosVendidos();
                        break;

                    case "Usuario":
                        ProductoBussiness.EliminarUsuarioId(this.Id);
                        cargoUsuarios();
                        break;

                    case "Venta":
                        ProductoBussiness.EliminarVentaId(this.Id);
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
