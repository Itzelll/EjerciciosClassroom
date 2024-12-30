using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Contratos.Models.Entidades
{
    public partial class TiposContratos
    {
        public TiposContratos()
        {
            Contratos = new HashSet<Contratos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Contratos> Contratos { get; set; }
    }
}
