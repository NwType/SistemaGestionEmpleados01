using SistemaGestionEmpelados.Modelos;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEmpleados.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public persona ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            persona p = new persona();
            if (tabla.Rows.Count > 0)
            {
                p.idpersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.nombre= tabla.Rows[0]["nombre"].ToString();
                p.apellido= tabla.Rows[0]["apellido"].ToString();
                p.estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
    }
}
