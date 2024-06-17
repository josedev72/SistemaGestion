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
    public partial class FormVenta : Form
    {
        private ApiService apiService;
        private int _id;

        public FormVenta(int id)
        {
            InitializeComponent();
            _id = id;
            apiService = new ApiService();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargarVenta();
        }

        private void Limpiar()
        {
            txtId.Text = txtComentarios.Text = txtIdUsuario.Text = string.Empty;
        }

        private async void CargarVenta()
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
                    string result = await apiService.GetDataAsync($"api/venta/{this._id}");
                    var regVenta = JsonConvert.DeserializeObject<RegVenta>(result);

                    txtId.Text = regVenta.Id.ToString();
                    txtComentarios.Text = regVenta.Comentarios.ToString();
                    txtIdUsuario.Text = regVenta.IdUsuario.ToString();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar Venta");
                }
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            RegVenta venta = new RegVenta();

            venta.Id = this._id;
            venta.Comentarios = txtComentarios.Text.Trim();
            venta.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());
            
            var json = JsonConvert.SerializeObject(venta);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            if (this._id == 0)
            {
                bool success = await apiService.PostDataAsync("api/venta", venta);
                if (success)
                {
                    MessageBox.Show("Venta creada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al crear la Venta");
                }
            }
            else
            {
                // PUT
                bool success = await apiService.PutDataAsync("api/venta", venta);
                if (success)
                {
                    MessageBox.Show("Venta actualizada con éxito");
                }
                else
                {
                    MessageBox.Show("Error al actualizar la Venta");
                }
            }

            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
    //public partial class FormUsuario : Form

    public class RegVenta
    {   //Id, Comentarios, IdUsuario
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }
    }
}