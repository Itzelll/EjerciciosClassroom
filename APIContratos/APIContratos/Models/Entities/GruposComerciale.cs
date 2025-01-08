using System;
using System.Collections.Generic;

namespace APIContratos.Models.Entities
{
    public partial class GruposComerciale
    {
        public GruposComerciale()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Rfc { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
