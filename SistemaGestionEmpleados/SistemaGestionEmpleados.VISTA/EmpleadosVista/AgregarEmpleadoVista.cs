using SistemaGestionEmpelados.Modelos;
using SistemaGestionEmpleados.BSS;
using SistemaGestionEmpleados.VISTA.ListarEmpleadosVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionEmpleados.VISTA.EmpleadosVista
{
    public partial class AgregarEmpleadoVista : Form
    {
        public AgregarEmpleadoVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            ListarPersonaVista fr = new ListarPersonaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.idpersona + " ";
                textBox4.Text = persona.nombre;
                textBox5.Text = persona.apellido;

            }
        }
        EmpleadoBss bssempleado = new EmpleadoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            EmpleadoBss bsse= new EmpleadoBss();
            empleado empleado = new empleado();
                empleado.idpersona = IdPersonaSeleccionada;
                empleado.puesto = textBox2.Text;
                empleado.salario =Convert.ToDecimal(textBox3.Text);
                empleado.fechaContratacion = dateTimePicker1.Value;
                bssempleado.InsertarEmpleadoBss(empleado);
                MessageBox.Show("empleado ha sido insertado correctamente");

        }
    }
}
