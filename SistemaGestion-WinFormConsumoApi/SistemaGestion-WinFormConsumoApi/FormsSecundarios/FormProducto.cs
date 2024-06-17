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
using System.Xml.Linq;

namespace SistemaGestion_WinFormConsumoApi.FormsSecundarios
{
    public partial class FormProducto : Form
    {
        private ApiService apiService;
        private int _id;

        public FormProducto(int id)
        {
            InitializeComponent();
            _id = id;
            apiService = new ApiService();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargarProducto();
        }

        private void Limpiar()
        {
            txtId.Text = txtDescripcion.Text = txtCosto.Text = txtPrecioVenta.Text =
                txtStock.Text = txtIdUsuario.Text = string.Empty;
        }

        private async void CargarProducto()
        {
            if (this._id == 0)
            {
                txtId.Text = this._id.ToString();
                btnAceptar.Text = "Guardar";
            }
            else
            {
                btnAceptar.Text = "Modificar";
                //Obtener registro
                try
                {
                    string result = await apiService.GetDataAsync($"api/producto/{this._id}");
                    var regProducto = JsonConvert.DeserializeObject<RegProducto>(result);


                    txtId.Text = regProducto.Id.ToString();
                    txtDescripcion.Text = regProducto.Descripcion;
                    txtCosto.Text = regProducto.Costo.ToString();
                    txtPrecioVenta.Text = regProducto.PrecioVenta.ToString();
                    txtStock.Text = regProducto.Stock.ToString();
                    txtIdUsuario.Text = regProducto.IdUsuario.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar Producto");
                }
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            RegProducto p = new RegProducto();

            p.Id = this._id;
            p.Descripcion = txtDescripcion.Text.Trim();
            p.Costo = Convert.ToDecimal(txtCosto.Text.Trim());
            p.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
            p.Stock = Convert.ToInt32(txtStock.Text.Trim());
            p.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());

            var json = JsonConvert.SerializeObject(p);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            if (this._id == 0)
            {
                //await apiService.PostDataAsync($"api/producto", p);
                bool success = await apiService.PostDataAsync("api/producto", p);
                if (success)
                {
                    MessageBox.Show("Producto creado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al crear el producto");
                }
            }
            else
            {
                // Si deseas usar el primer método PUT
                bool success = await apiService.PutDataAsync("api/producto", p);
                if (success)
                {
                    MessageBox.Show("Producto actualizado con éxito");
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
    public class RegProducto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = "Producto no encontrado";  // Valor predeterminado
        public decimal Costo { get; set; } = 0;
        public decimal PrecioVenta { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int IdUsuario { get; set; }
    }
}
