using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWindowsForm1.Formularios
{
    public partial class FormularioInicio : Form
    {
        public FormularioInicio()
        {
            InitializeComponent();
        }

        private void btnFormObtenerDatos_Click(object sender, EventArgs e)
        {
            ObtenerDatos obtenerDatosForm = new ObtenerDatos();

            obtenerDatosForm.Show();
        }

        private void btnFormAltaPersona_Click(object sender, EventArgs e)
        {
            AltaPersona altaPersonaForm = new AltaPersona();

            altaPersonaForm.Show();
        }
    }
}
