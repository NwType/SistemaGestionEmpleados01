using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEmpelados.Modelos
{
    public class empleado
    {
        public int idpersona {  get; set; }
        public string puesto { get; set; }
        public decimal salario { get; set; }
        public DateTime fechaContratacion {  get; set; }
    }
}
