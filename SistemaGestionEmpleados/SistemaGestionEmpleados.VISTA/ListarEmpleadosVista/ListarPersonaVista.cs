using SistemaGestionEmpleados.BSS;
using SistemaGestionEmpleados.VISTA.EmpleadosVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionEmpleados.VISTA.ListarEmpleadosVista
{
    public partial class ListarPersonaVista : Form
    {
        public ListarPersonaVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        public void ListarPersonaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEmpleadoVista.IdPersonaSeleccionada= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
