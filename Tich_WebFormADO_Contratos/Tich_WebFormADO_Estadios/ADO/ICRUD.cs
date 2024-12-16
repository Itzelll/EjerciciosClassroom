using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tich_WebFormADO_Estadios.Entidades;

namespace Tich_WebFormADO_Estadios.ADO
{
    internal interface ICRUD
    {
        List<GruposComerciales> Consultar();

        GruposComerciales Consultar(int id);

        void Agregar(GruposComerciales grupo);

        void Actualizar(GruposComerciales grupo);

        void Eliminar(int id);
    }
}
