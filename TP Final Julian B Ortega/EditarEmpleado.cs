using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Final_Julian_B_Ortega
{
    public partial class winEditar : Form
    {
        private Empleado target;

        public winEditar(Empleado empleado)
        {
            target = empleado;
            InitializeComponent();

            lblNombreEmpleado.Text = "Ahora editando a " + empleado.Nombre;
            inputNombre.Text = empleado.Nombre;
            inputDNI.Text = empleado.DNI.ToString();
            inputEdad.Text = empleado.Edad.ToString();
            inputSalario.Text = empleado.Salario.ToString();
            chkCasado.Checked = empleado.Casado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!ValidateFields())
            {
                lblNombreEmpleado.Text = "ERROR - Validar que los campos esten rellenos y sean válidos";
                lblNombreEmpleado.ForeColor = Color.Red;
                return;
            }

            UpdateTarget();
            Close();
        }

        private bool ValidateFields()
        {
            if (inputNombre.Text.Trim().Length < 1) return false;
            if (inputDNI.Text.Trim().Length < 1 || !int.TryParse(inputDNI.Text, out int dni)) return false;
            if (inputEdad.Text.Trim().Length < 1 || !int.TryParse(inputEdad.Text, out int edad)) return false;
            if (inputSalario.Text.Trim().Length < 1 || !double.TryParse(inputSalario.Text, out double salario)) return false;

            return true;
        }

        private void UpdateTarget()
        {
            target.Nombre = inputNombre.Text;
            target.DNI = Convert.ToInt32(inputDNI.Text);
            target.Edad = Convert.ToInt32(inputEdad.Text);
            target.Salario = Convert.ToDouble(inputSalario.Text);
            target.Casado = Convert.ToBoolean(chkCasado.Checked);

            DBFetcher.UpdateEmpleado(target);
        }


    }
}
