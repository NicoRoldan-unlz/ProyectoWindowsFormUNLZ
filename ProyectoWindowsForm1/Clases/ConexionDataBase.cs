using Microsoft.Data.SqlClient;
using ProyectoWindowsForm1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWindowsForm1.Clases
{
    public class ConexionDataBase
    {
        public string StringConexion()
        {
            string conexion = "Data Source = DESKTOP-ODNOEU4\\SQLEXPRESS; Initial Catalog = ProgramacionIV; User ID = sa; Password = programacioniv; " +
                "Encrypt = False; TrustServerCertificate = False;";

            return conexion;
        }
    }
}
