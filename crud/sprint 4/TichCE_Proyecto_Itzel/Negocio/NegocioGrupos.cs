using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    internal class NegocioGrupos
    {
        ADOGrupos conn = new ADOGrupos();

        public List<GruposComerciales> Consultar()
        {
            return conn.Consultar();
        }

        public GruposComerciales Consultar(int id)
        {
            return conn.Consultar(id);
        }

        public void Agregar(GruposComerciales grupo)
        {
            conn.Agregar(grupo);
        }

        public void Actualizar(GruposComerciales grupo)
        {
            conn.Actualizar(grupo);
        }

        public void Eliminar(int id)
        {
            conn.Eliminar(id);
        }
    }
}
