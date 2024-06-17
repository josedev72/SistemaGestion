
using Newtonsoft.Json;
using SistemaGestion_WinFormConsumoApi.FormsSecundarios;
using SistemaGestion_WinFormConsumoApi.Servicio;
using System.Data;
using System.Windows.Forms.Design;

namespace SistemaGestion_WinFormConsumoApi
{
    public partial class FormPrincipal : Form
    {
        private ApiService apiService;

        private int _id;
        private string _tabla;

        public FormPrincipal()
        {
            InitializeComponent();
            apiService = new ApiService();
            CargarComboBox();
        }

        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
             
        }

        private async Task CargarComboBox()
        {
            try
            {
                cmbTablas.Visible = false;
                string result = await apiService.GetDataAsync("api/tablas");
                var tablas = JsonConvert.DeserializeObject<List<string>>(result);
                cmbTablas.DataSource = tablas;
                cmbTablas.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar Listado de Tablas: {ex.Message}");
            }
        }

        private async void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDGV();
            //FormatearDgvDatos();
        }

        private async void CargarDGV()
        {
            try
            {
                this._tabla = cmbTablas.SelectedItem.ToString();
                string result = await apiService.GetDataAsync($"api/{this._tabla}");
                var data = JsonConvert.DeserializeObject<DataTable>(result);
                dgvDatos.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la Tabla: {ex.Message}");
            }

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
                if (columna.ValueType == typeof(int) || columna.ValueType == typeof(decimal) || columna.ValueType == typeof(double) || columna.ValueType == typeof(long) || columna.ValueType == typeof(short))
                {
                    columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Ver si encabezado es "Contrasenia"
                if (columna.HeaderText.Equals("Contrasenia") || columna.HeaderText.Equals("contrasenia"))
                {
                    columna.Visible = false;
                }

                //1° caracter Mayúscula
                columna.HeaderText = char.ToUpper(columna.HeaderText[0]) + columna.HeaderText.Substring(1).ToLower();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AbrirForm(0);
        }

        private void FormProducto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarDGV();
        }

        private void FormProductoVendido_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarDGV();
        }

        private void FormUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarDGV();
        }

        private void FormVenta_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarDGV();
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
                    Console.WriteLine("Tabla no encontrada", "Advertencia . . .", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDatos.Rows[e.RowIndex];

                // Acceder a la fila seleccionada
                this._id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                this._tabla = cmbTablas.Text.Trim();
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
                    Console.WriteLine("Tabla no encontrada", "Advertencia . . .", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this._tabla) && this._id > 0)
            {
                switch (this._tabla)
                {
                    case "Producto":                     
                    case "ProductoVendido":                        
                    case "Usuario":                        
                    case "Venta":
                        await apiService.DeleteDataAsync($"api/{this._tabla}/{this._id}");
                        MessageBox.Show("Borrado exitoso", "Advertencia . . .", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("Tabla no encontrada", "Advertencia . . .", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

                CargarDGV();
            }
        }
    }
}
