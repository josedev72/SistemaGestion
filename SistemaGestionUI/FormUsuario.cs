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
    }
}
