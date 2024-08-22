using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoWindowsForm1.Clases;

namespace ProyectoWindowsForm1.Modelos
{
    public class Persona
    {
        public int Id_Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Edad{ get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? NombreHijo { get; set; }

        public List<Persona> TraerPersonas()
        {
            ConexionDataBase conexionDataBase = new ConexionDataBase();

            string conexion = conexionDataBase.StringConexion();

            string consulta = "SELECT Id_Persona, Nombre, Apellido, Edad, FechaNacimiento FROM Personas;";

            List<Persona> personas = new List<Persona>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Persona persona = new Persona()
                                {
                                    Id_Persona = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Edad = reader.GetInt32(3),
                                    FechaNacimiento = reader.GetDateTime(4)
                                };
                                personas.Add(persona);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            
            return personas;
        }

        public Persona TraerPersona(int idPersona)
        {
            ConexionDataBase conexionDataBase = new ConexionDataBase();
            string conexion = conexionDataBase.StringConexion();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT Id_Persona, Nombre, Apellido, Edad, FechaNacimiento FROM Personas ");
            stringBuilder.Append("WHERE Id_Persona = @id_Persona;");
            string consulta = stringBuilder.ToString();

            Persona persona = new Persona();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id_Persona", idPersona);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                persona.Id_Persona = reader.GetInt32(0);
                                persona.Nombre = reader.GetString(1);
                                persona.Apellido = reader.GetString(2);
                                persona.Edad = reader.GetInt32(3);
                                persona.FechaNacimiento = reader.GetDateTime(4);
                            }
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }

            return persona;
        }

        public bool AltaPersona(Persona persona)
        {
            ConexionDataBase conexionDataBase = new ConexionDataBase();
            string conexion = conexionDataBase.StringConexion();

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Personas (Nombre, Apellido, Edad, FechaNacimiento) ");
            sb.Append("VALUES (@Nombre, @Apellido, @Edad, @FechaNacimiento);");
            string consulta = sb.ToString();

            bool existoso = false;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Nombre", persona.Nombre);
                        sqlCommand.Parameters.AddWithValue("@Apellido", persona.Apellido);
                        sqlCommand.Parameters.AddWithValue("@Edad", persona.Edad);
                        sqlCommand.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
                existoso = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return existoso;
        }
    }

}
