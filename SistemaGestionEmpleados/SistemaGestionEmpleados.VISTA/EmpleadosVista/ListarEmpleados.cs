using SistemaGestionEmpleados.BSS;
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
    public partial class ListarEmpleados : Form
    {
        public ListarEmpleados()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();
        private void ListarEmpleados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarEmpleadoBss();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            AgregarEmpleadoVista fr = new AgregarEmpleadoVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadoBss();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdEmpleadoseleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarEmpleadoBss(IdEmpleadoseleccionado);
                dataGridView1.DataSource = bss.ListarEmpleadoBss();
            }
        }
    }
}
