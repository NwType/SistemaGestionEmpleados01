using SistemaGestionEmpelados.Modelos;
using SistemaGestionEmpleados.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEmpleados.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }
        public void InsertarEmpleadoBss(empleado e)
        {
            dal.InsertarEmpleadoDal(e);
        }
        public void EditarEmpleadoBss(empleado e)
        {
            dal.EditarEmpleadoDaL(e);
        }
        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
