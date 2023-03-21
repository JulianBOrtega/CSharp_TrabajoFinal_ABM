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
    public partial class winMain : Form
    {
        private List<Empleado> empleados = new List<Empleado>();

        public winMain()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            if(dgEmpleados.Columns[e.ColumnIndex].Name == "AccionEditar")
            {
                winEditar editor = new winEditar(empleados[e.RowIndex]);
                editor.FormClosed += new FormClosedEventHandler(UpdateGrid);
                editor.ShowDialog();
            }

            if (dgEmpleados.Columns[e.ColumnIndex].Name == "AccionEliminar")
            {
                DBFetcher.DeleteEmpleado(empleados[e.RowIndex]);
                UpdateGrid();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                lblError.Text = "* Para el nuevo empleado, hace falta rellenar todos los campos y comprobar que sus datos sean válidos.";
                return;
            }

            Empleado nuevoEmpleado = new Empleado(inputNombre.Text.Trim(), Convert.ToInt32(inputDNI.Text.Trim()),
                Convert.ToInt32(inputEdad.Text.Trim()), chkCasado.Checked, Convert.ToSingle(inputSalario.Text.Trim()));

            if (!DBFetcher.CreateEmpleado(nuevoEmpleado))
            {
                lblError.Text = "* ERROR - Ocurrió un error relacionado a la base de datos al agregar el nuevo empleado.";
                return;
            }

            lblError.Text = "";
            inputNombre.Clear();
            inputDNI.Clear();
            inputEdad.Clear();
            inputSalario.Clear();
            chkCasado.Checked = false;
            UpdateGrid();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (inputFiltro.Text.Trim().Length < 1)
            {
                UpdateGrid();
                return;
            }

            string[] keywords = inputFiltro.Text.Trim().Split(' ');
            List<Empleado> resultados = new List<Empleado>();

            foreach (string k in keywords)
            {
                resultados.AddRange(empleados.FindAll((em) => em.Nombre.ToLower().Contains(k.ToLower())));
            }

            UpdateGrid(resultados);

            // Selecciona el texto introducido para reemplazarlo facilmente
            inputFiltro.Focus();
            SendKeys.Send("^a");
        }

        private void inputFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            // Código para correr la función de Click del filtro si el usuario presiona enter en el textfield
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnFiltrar.PerformClick();
            }
        }

        #region Funciones de utilidad (Helpers)

        private bool ValidateFields()
        {
            if (inputNombre.Text.Trim().Length < 1) return false;
            if (inputDNI.Text.Trim().Length < 1 || !int.TryParse(inputDNI.Text, out int dni)) return false;
            if (inputEdad.Text.Trim().Length < 1 || !int.TryParse(inputEdad.Text, out int edad)) return false;
            if (inputSalario.Text.Trim().Length < 1 || !double.TryParse(inputSalario.Text, out double salario)) return false;

            return true;
        }

        private void UpdateGrid(object sender, FormClosedEventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid(List<Empleado> resultadosFiltrados = null)
        {
            dgEmpleados.AutoGenerateColumns = false;

            if (resultadosFiltrados != null)
                dgEmpleados.DataSource = resultadosFiltrados;
            else
                dgEmpleados.DataSource = empleados = DBFetcher.GetAllEmpleados();

            dgEmpleados.Refresh();
        }

        #endregion
    }
}
