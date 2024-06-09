using SistemaGestionData;
using SistemaGestionBussiness;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEntities;

namespace SistemaGestionUI
{
    public partial class FormProductoVendido : Form
    {
        private int Id;
        public FormProductoVendido(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoVendido pv = new ProductoVendido();
            pv.Id = this.Id;
            pv.IdProducto = Convert.ToInt32(txtIdProducto.Text.Trim());
            pv.Stock = Convert.ToDecimal(txtStock.Text.Trim());
            pv.IdVenta = Convert.ToInt32(txtIdVenta.Text.Trim());


            if (Id == 0)
            {
                ProductoVendidoBussiness.CrearProductoVendido(pv);
            }
            else
            {
                ProductoVendidoBussiness.ModificarProductoVendido(pv);
            }

            this.Close();
        }

        private void FormProductoVendido_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargarProductoVendido();
        }

        private void CargarProductoVendido()
        {
            if (this.Id == 0)
            {
                txtId.Text = this.Id.ToString();
                btnAceptar.Text = "Guardar";
            }
            else
            {
                btnAceptar.Text = "Modificar";
                //Obtener registro
                ProductoVendido pv = ProductoVendidoBussiness.ObtenerProductoVendido(this.Id);
                txtId.Text = pv.Id.ToString();
                txtIdProducto.Text = pv.IdProducto.ToString();
                txtStock.Text = pv.Stock.ToString();
                txtIdVenta.Text = pv.IdVenta.ToString();

                txtIdProducto.Focus();
            }
        }

        private void Limpiar()
        {
            txtId.Text = txtIdProducto.Text = txtStock.Text = txtIdVenta.Text = string.Empty;
        }
    }
}
