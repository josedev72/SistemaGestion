using Newtonsoft.Json;
using SistemaGestion_WinFormConsumoApi.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion_WinFormConsumoApi.FormsSecundarios
{
    public partial class FormProductoVendido : Form
    {
        private ApiService apiService;
        private int _id;

        public FormProductoVendido(int id)
        {
            InitializeComponent();
            _id = id;
            apiService = new ApiService();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductoVendido_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargarProductoVendido();
        }

        private void Limpiar()
        {
            txtId.Text = txtIdProducto.Text = txtStock.Text = txtIdVenta.Text = string.Empty;
        }

        private async void CargarProductoVendido()
        {
            if (this._id == 0)
            {
                txtId.Text = this._id.ToString();
                btnAceptar.Text = "Guardar";
            }
            else
            {
                btnAceptar.Text = "Modificar";
                try
                {
                    string result = await apiService.GetDataAsync($"api/productovendido/{this._id}");
                    var regProductoV = JsonConvert.DeserializeObject<RegProductoVendido>(result);

                    txtId.Text = regProductoV.Id.ToString();
                    txtIdProducto.Text = regProductoV.IdProducto.ToString();
                    txtStock.Text = regProductoV.Stock.ToString();
                    txtIdVenta.Text = regProductoV.IdVenta.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar Producto");
                }
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            RegProductoVendido pv = new RegProductoVendido();

            pv.Id = this._id;
            pv.IdProducto = Convert.ToInt32(txtIdProducto.Text.Trim());
            pv.Stock = Convert.ToDecimal(txtStock.Text.Trim());
            pv.IdVenta = Convert.ToDecimal(txtIdVenta.Text.Trim());

            var json = JsonConvert.SerializeObject(pv);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            if (this._id == 0)
            {
                bool success = await apiService.PostDataAsync("api/productovendido", pv);
                if (success)
                {
                    MessageBox.Show("Producto Vendido creado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al crear el Pproducto Vendido");
                }
            }
            else
            {
                // Si deseas usar el primer método PUT
                bool success = await apiService.PutDataAsync("api/productovendido", pv);
                if (success)
                {
                    MessageBox.Show("Producto Vendido actualizado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto");
                }
            }

            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
    //Fin public partial
    public class RegProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; } = 0;  // Valor predeterminado
        public decimal Stock { get; set; } = 0;
        public decimal IdVenta { get; set; }
    }
}
