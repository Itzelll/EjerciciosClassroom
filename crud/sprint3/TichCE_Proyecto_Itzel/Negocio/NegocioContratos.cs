using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegocioContratos
    {
        ADOContratos conn = new ADOContratos();

        public List<Contratos> Consultar()
        {
            return conn.Consultar();
        }

        public Contratos Consultar(int id)
        {
            return conn.Consultar(id);
        }

        public void Agregar(Contratos c)
        {
            conn.Agregar(c);
        }

        public void Actualizar(Contratos c)
        {
            conn.Actualizar(c);
        }

        public void Eliminar(int id)
        {
            conn.Eliminar(id);
        }
    }
}
