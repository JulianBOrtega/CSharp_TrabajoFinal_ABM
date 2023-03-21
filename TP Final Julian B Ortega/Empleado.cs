using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final_Julian_B_Ortega
{
    public class Empleado
    {
        public int ID { get; set; } = -1;
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public int Edad { get; set; }
        public bool Casado { get; set; }
        public double Salario { get; set; }

        public Empleado(int id, string nombre, int dni, int edad, bool casado, double salario)
        {
            ID = id;
            Nombre = nombre;
            DNI = dni;
            Edad = edad;
            Casado = casado;
            Salario = salario;
        }

        public Empleado(string nombre, int dni, int edad, bool casado, double salario)
        {
            Nombre = nombre;
            DNI = dni;
            Edad = edad;
            Casado = casado;
            Salario = salario;
        }
    }
}
