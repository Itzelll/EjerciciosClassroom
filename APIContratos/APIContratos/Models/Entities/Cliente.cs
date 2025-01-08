using System;
using System.Collections.Generic;

namespace APIContratos.Models.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Contratos = new HashSet<Contrato>();
        }

        public int Id { get; set; }
        public int? Grupo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        public virtual GruposComerciale? GrupoNavigation { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
