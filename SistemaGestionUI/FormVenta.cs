using SistemaGestionBussiness;
using SistemaGestionData;

using SistemaGestionEntities;
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
    public partial class FormVenta : Form
    {
        private int Id;
        public FormVenta(int id)
        {
            InitializeComponent();
            Id = id;
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

        private void CargarVenta()
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
                Venta v = VentaBussiness.ObtenerVenta(this.Id);
                txtId.Text = v.Id.ToString();
                txtComentarios.Text = v.Comentarios;
                txtIdUsuario.Text = v.IdUsuario.ToString();
            }
        }

        private void Limpiar()
        {
            txtId.Text = txtComentarios.Text = txtIdUsuario.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.Id = this.Id;
            v.Comentarios = txtComentarios.Text.Trim();            
            v.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());


            if (Id == 0)
            {
                VentaBussiness.CrearVenta(v);
            }
            else
            {
                VentaBussiness.ModificarVenta(v);
            }

            this.Close();
        }
    }
}
