using SistemaGestionBussiness;
using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class FormProducto : Form
    {
        int Id;
        public FormProducto(int id)
        {
            this.Id = id;
            InitializeComponent();
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

        private void CargarProducto()
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
                Producto p = ProductoBussiness.ObtenerProducto(this.Id);
                txtId.Text = p.Id.ToString();
                txtDescripcion.Text = p.Descripcion;
                txtCosto.Text =p.Costo.ToString();
                txtPrecioVenta.Text = p.PrecioVenta.ToString();
                txtStock.Text = p.Stock.ToString();
                txtIdUsuario.Text = p.IdUsuario.ToString();
            }
        }

        private void Limpiar()
        {
            txtId.Text = txtDescripcion.Text = txtCosto.Text = txtPrecioVenta.Text =
                txtStock.Text = txtIdUsuario.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Id = this.Id;
            p.Descripcion = txtDescripcion.Text.Trim();
            p.Costo = Convert.ToDecimal(txtCosto.Text.Trim());
            p.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
            p.Stock = Convert.ToInt32(txtStock.Text.Trim());
            p.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());


            if (Id == 0)
            {
                ProductoBussiness.CrearProducto(p);
            }
            else
            {
                ProductoBussiness.ModificarProducto(p);
            }

            this.Close();
        }
    }
}
