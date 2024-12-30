using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Contratos.Models.Entidades
{
    public partial class Contratos
    {
        public int Id { get; set; }
        public int? Cliente { get; set; }
        public int? TipoContrato { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public decimal? Monto { get; set; }
        public string Descripcion { get; set; }

        public virtual Clientes Clientes { get; set; }
        public virtual TiposContratos TiposContratos { get; set; }
    }
}
