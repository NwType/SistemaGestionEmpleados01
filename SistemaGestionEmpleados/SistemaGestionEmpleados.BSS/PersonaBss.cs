using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEmpelados.Modelos;
using SistemaGestionEmpleados.DAL;

namespace SistemaGestionEmpleados.BSS
{
    public class PersonaBss
    {
        PersonaDal dal=new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }
        public persona ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
    }
}
