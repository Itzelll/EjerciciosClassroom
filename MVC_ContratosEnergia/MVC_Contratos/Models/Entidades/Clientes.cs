using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Contratos.Models.Entidades
{
    public partial class Clientes
    {
        public Clientes()
        {
            Contratos = new HashSet<Contratos>();
        }

        public int Id { get; set; }
        public int? Grupo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual GruposComerciales GrupoNavigation { get; set; }
        public virtual ICollection<Contratos> Contratos { get; set; }
    }
}
