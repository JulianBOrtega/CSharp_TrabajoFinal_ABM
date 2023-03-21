using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TP_Final_Julian_B_Ortega
{
    class DBFetcher
    {
        public static List<Empleado> GetAllEmpleados()
        {
            try
            {
                List<Empleado> empleados = new List<Empleado>();

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ToString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Empleados;", connection);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        empleados.Add(ObtenerEmpleado(reader));
                    }

                }

                return empleados;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Ha ocurrido un error con relación a la base de datos: \n " + err.Message);
                Console.WriteLine(err);
                return null;
            }
            
        }

        public static bool CreateEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ToString()))
                {
                    connection.Open();

                    List<string> data = new List<string>()
                    {
                        empleado.Nombre,
                        empleado.DNI.ToString(),
                        empleado.Edad.ToString(),
                        Convert.ToInt32(empleado.Casado).ToString(),
                        empleado.Salario.ToString()
                    };

                    string dataString = "('" + empleado.Nombre + "', " + empleado.DNI + ", " + empleado.Edad + ", "
                        + Convert.ToInt32(empleado.Casado) + ", " + empleado.Salario + ")";
                    string sqlInsert = "INSERT INTO Empleados(NombreCompleto, DNI, Edad, Casado, Salario) VALUES " + dataString;

                    SqlCommand command = new SqlCommand(sqlInsert, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Ha ocurrido un error con relación a la base de datos: \n " + err.Message);
                Console.WriteLine(err);
                return false;
            }
        }

        public static bool UpdateEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ToString()))
                {
                    connection.Open();

                    string dataString = "SET ";
                    dataString += "NombreCompleto = '" + empleado.Nombre + "', ";
                    dataString += "DNI = " + empleado.DNI + ", ";
                    dataString += "Edad = " + empleado.Edad + ", ";
                    dataString += "Casado = " + Convert.ToInt32(empleado.Casado) + ", ";
                    dataString += "Salario = " + empleado.Salario + " ";

                    string sqlUpdate = "UPDATE Empleados " + dataString + " WHERE Id = " + empleado.ID;

                    Console.WriteLine(sqlUpdate);

                    SqlCommand command = new SqlCommand(sqlUpdate, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Ha ocurrido un error con relación a la base de datos: \n " + err.Message);
                Console.WriteLine(err);
                return false;
            }
        }

        public static bool DeleteEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ToString()))
                {
                    connection.Open();

                    string sqlDelete = "DELETE FROM Empleados WHERE id = " + empleado.ID;

                    SqlCommand command = new SqlCommand(sqlDelete, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Ha ocurrido un error con relación a la base de datos: \n " + err.Message);
                Console.WriteLine(err);
                return false;
            }
        }

        private static Empleado ObtenerEmpleado(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string nombre = Convert.ToString(reader["NombreCompleto"]);
            int dni = Convert.ToInt32(reader["DNI"]);
            int edad = Convert.ToInt32(reader["Edad"]);
            bool casado = Convert.ToBoolean(reader["Casado"]);
            double salario = Convert.ToDouble(reader["Salario"]);

            return new Empleado(id, nombre, dni, edad, casado, salario);
        }
    }
}
