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

namespace SistemaGestion_WinFormConsumoApi
{
    public partial class FormLoguin : Form
    {
        public static DialogResult rta;
        private ApiService apiService;
        private string _retornoLoguin;

        public string rtaUsuario
        {
            get { return _retornoLoguin; }
            set { _retornoLoguin = value; }
        }

        public FormLoguin()
        {
            InitializeComponent();
            apiService = new ApiService();

            CargarCmbUsuarios();
        }

        List<RegUsuario> listaUsuarios;
        private async Task CargarCmbUsuarios()
        {
            try
            {
                cmbUsuarios.Visible = txtContrasenia.Visible= false;
                string result = await apiService.GetDataAsync($"api/usuario");
                var data = JsonConvert.DeserializeObject<DataTable>(result);
                
                listaUsuarios = new List<RegUsuario>();
                
                foreach (DataRow fila in data.Rows)
                {
                    //int id = Convert.ToInt32(fila["Id"].ToString());
                    //string nombre = (string)fila["NombreUsuario"];
                    RegUsuario reg = new RegUsuario();
                    reg.Id = Convert.ToInt32(fila["Id"].ToString());
                    reg.NombreUsuario = fila["NombreUsuario"].ToString();
                    reg.Contrasenia = fila["Contrasenia"].ToString();
                    listaUsuarios.Add(reg);

                    cmbUsuarios.Items.Add(new { Id = reg.Id, NombreUsuario = reg.NombreUsuario });
                }

                // Establecer la propiedad DisplayMember y ValueMember
                cmbUsuarios.DisplayMember = "NombreUsuario";
                cmbUsuarios.ValueMember = "Id";

                cmbUsuarios.Visible = txtContrasenia.Visible =  true;

                cmbUsuarios.SelectedIndex = 0;
                cmbUsuarios.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar Listado de Tablas: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar form con resultado Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            if (string.IsNullOrEmpty(cmbUsuarios.Text.Trim()) || string.IsNullOrEmpty(txtContrasenia.Text.Trim()))
            {
                MessageBox.Show("Debe elegir un usuario", "Advertencia . . .", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUsuarios.Focus();
                return;
            }

            foreach (RegUsuario r in listaUsuarios)
            {
                if (txtContrasenia.Text == r.Contrasenia && cmbUsuarios.Text == r.NombreUsuario)
                {
                    bandera = true;
                    break;
                }
            }

            if (bandera)
            {
                // Establecer devolucion
                _retornoLoguin = cmbUsuarios.Text.Trim();

                // Cerrar form con resultado OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El Usuario y/o Contraseña no son válidos ! ! !", "Advertencia . . .", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUsuarios.Focus();
                return;
            }
        }
    }

    public class RegUsuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
