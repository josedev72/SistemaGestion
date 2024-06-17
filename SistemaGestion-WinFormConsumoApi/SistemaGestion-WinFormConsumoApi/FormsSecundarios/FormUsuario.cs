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
    public partial class FormUsuario : Form
    {
        private ApiService apiService;
        private int _id;

        public FormUsuario(int id)
        {
            InitializeComponent();
            _id = id;
            apiService = new ApiService();
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

        private void Limpiar()
        {
            txtId.Text = txtNombre.Text = txtApellido.Text = txtNombreUsuario.Text = txtContrasenia.Text = txtMail.Text = string.Empty;
        }

        private async void CargarUsuario()
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
                    string result = await apiService.GetDataAsync($"api/usuario/{this._id}");
                    var regUsuario = JsonConvert.DeserializeObject<RegUsuario>(result);

                    txtId.Text = regUsuario.Id.ToString();
                    txtNombre.Text = regUsuario.Nombre.ToString();
                    txtApellido.Text = regUsuario.Apellido.ToString();
                    txtNombreUsuario.Text = regUsuario.NombreUsuario.ToString();
                    txtContrasenia.Text = regUsuario.Contrasenia.ToString();
                    txtMail.Text = regUsuario.Mail.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar Usuario");
                }
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            RegUsuario usuario = new RegUsuario();

            usuario.Id = this._id;
            usuario.Nombre = txtNombre.Text.Trim();
            usuario.Nombre = txtNombre.Text.Trim();
            usuario.Apellido = txtApellido.Text.Trim();
            usuario.NombreUsuario = txtNombreUsuario.Text.Trim();
            usuario.Contrasenia = txtContrasenia.Text.Trim();
            usuario.Mail = txtMail.Text.Trim();
            

            var json = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            if (this._id == 0)
            {
                bool success = await apiService.PostDataAsync("api/usuario", usuario);
                if (success)
                {
                    MessageBox.Show("Usuario creado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al crear el Usuario");
                }
            }
            else
            {
                // PUT
                bool success = await apiService.PutDataAsync("api/usuario", usuario);
                if (success)
                {
                    MessageBox.Show("Usuario actualizado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Usuario");
                }
            }

            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
    //public partial class FormUsuario : Form

    public class RegUsuario
    {   //Id, Nombre, Apellido, NombreUsuario, Contrasenia, Mail
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Mail { get; set; }
    }
}
