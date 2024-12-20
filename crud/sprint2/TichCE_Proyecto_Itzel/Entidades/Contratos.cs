using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contratos
    {
        public int id { get; set; }
        public int cliente { get; set; }
        public int tipoContrato { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public decimal monto { get; set; }
        public string descripcion { get; set; }
    }
}
