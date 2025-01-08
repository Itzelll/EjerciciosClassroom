using System;
using System.Collections.Generic;

namespace APIContratos.Models.Entities
{
    public partial class TiposContrato
    {
        public TiposContrato()
        {
            Contratos = new HashSet<Contrato>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
