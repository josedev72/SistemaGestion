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
    public partial class FormUsuario : Form
    {
        private int Id;
        public FormUsuario(int id)
        {
            InitializeComponent();
            Id = id;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargarUsuario();
        }

        private void CargarUsuario()
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
                Usuario u = UsuarioBussiness.ObtenerUsuario(this.Id);
                txtId.Text = u.Id.ToString();
                txtNombre.Text = u.Nombre.ToString();
                txtApellido.Text = u.Apellido.ToString();
                txtNombreUsuario.Text = u.NombreUsuario.ToString();
                txtContrasenia.Text = u.Contrasenia.ToString();
                txtMail.Text = u.Mail.ToString();
            }

            txtNombre.Focus();
        }

        private void Limpiar()
        {
            txtId.Text = txtNombre.Text = txtApellido.Text = txtNombreUsuario.Text = txtContrasenia.Text =
                txtMail.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Id = this.Id;
            u.Nombre = txtNombre.Text.Trim();
            u.Apellido = txtApellido.Text.Trim();
            u.NombreUsuario = txtNombreUsuario.Text.Trim();
            u.Contrasenia = txtContrasenia.Text.Trim();
            u.Mail = txtMail.Text.Trim();
            
            if (Id == 0)
            {
                UsuarioBussiness.CrearUsuario(u);
            }
            else
            {
                UsuarioBussiness.ModificarUsuario(u);
            }

            this.Close();
        }
    }
}
