using System;
using System.Collections.Generic;

namespace MVC_Contratos.Models.Entities
{
    public partial class Contrato
    {
        public int Id { get; set; }
        public int? Cliente { get; set; }
        public int? TipoContrato { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public decimal? Monto { get; set; }
        public string? Descripcion { get; set; }

        public virtual Cliente? ClienteNavigation { get; set; }
        public virtual TiposContrato? TipoContratoNavigation { get; set; }
    }
}
