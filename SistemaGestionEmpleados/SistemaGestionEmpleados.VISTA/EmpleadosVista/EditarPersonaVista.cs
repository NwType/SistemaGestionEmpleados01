using SistemaGestionEmpelados.Modelos;
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
    public partial class EditarPersonaVista : Form
    {
        int idx = 0;
        empleado e = new empleado();
        EmpleadoBss bss= new EmpleadoBss(); 
        public EditarPersonaVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EditarPersonaVista_Load(object sender, EventArgs e)
        {
            //e = bss.EditarEmpleadoBss(idx);
             
        }
    }
}
