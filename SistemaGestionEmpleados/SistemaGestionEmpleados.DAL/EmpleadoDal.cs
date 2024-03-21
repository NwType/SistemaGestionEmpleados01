using SistemaGestionEmpelados.Modelos;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaGestionEmpleados.DAL
{
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from empleado";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarEmpleadoDal(empleado e)
        {
            string consulta = "INSERT INTO empleado VALUES (" + e.idpersona + ", '" + e.puesto + "', '" + e.salario + "', '" + e.fechaContratacion + "')";
            conexion.Ejecutar(consulta);
        }
        public void EditarEmpleadoDaL(empleado e)
        {
            string consulta = "UPDATE empleado SET puesto = '" + e.puesto + "', salario = " + e.salario + ", fechaContratacion = '" + e.fechaContratacion + "' WHERE idPersona = " + e.idpersona;
            conexion.Ejecutar(consulta);
        }
        public empleado ObtenerEmpleadoId(int id)
        {
            string consulta = "select * from marca where idempleado=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            empleado e = new empleado();
            if (tabla.Rows.Count > 0)
            {
                e.idempleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                e.puesto = tabla.Rows[0]["puesto"].ToString();
                e.salario= Convert.ToDecimal(tabla.Rows[0]["salario"]);
                e.fechaContratacion = Convert.ToDateTime(tabla.Rows[0]["fechacontratacion"]);
            }
            return e;
        }
        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleado where idempleado=" + id;
            conexion.Ejecutar(consulta);
        }

    }
}
