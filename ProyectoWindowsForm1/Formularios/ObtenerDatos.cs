using Microsoft.IdentityModel.Tokens;
using ProyectoWindowsForm1.Modelos;
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
    public partial class ObtenerDatos : Form
    {
        public ObtenerDatos()
        {
            InitializeComponent();
        }

        Persona persona = new Persona();

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            GuardarPersonas();
        }

        private void GuardarPersonas()
        {
            dataGridViewPersonas.Rows.Clear();

            if (textBoxIdPersona.Value == 0)
            {
                List<Persona> personas = new List<Persona>();
                personas = persona.TraerPersonas();

                foreach (var persona in personas)
                {
                    dataGridViewPersonas.Rows.Add(persona.Id_Persona, persona.Nombre, persona.Apellido, persona.Edad, persona.FechaNacimiento);
                }
            }
            else
            {
                int idPersona = Convert.ToInt32(textBoxIdPersona.Value);

                Persona nuevaPersona = new Persona();
                nuevaPersona = nuevaPersona.TraerPersona(idPersona);

                dataGridViewPersonas.Rows.Add(nuevaPersona.Id_Persona, nuevaPersona.Nombre, 
                    nuevaPersona.Apellido, nuevaPersona.Edad, persona.FechaNacimiento);
            }
        }

        private void dataGridViewPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
