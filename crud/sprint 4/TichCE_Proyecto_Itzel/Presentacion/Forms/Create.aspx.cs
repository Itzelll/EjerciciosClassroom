using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Forms
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            NegocioContratos lista = new NegocioContratos();
            Contratos c = new Contratos();

            c.cliente = int.Parse(tbcliente.Text);
            c.tipoContrato = int.Parse(tbtipo.Text);
            c.fechaInicio = DateTime.Parse(tbinicio.Text);
            c.fechaFin = DateTime.Parse(tbfinal.Text);
            c.monto = Decimal.Parse(tbmonto.Text);
            c.descripcion = tbdesc.Text;

            lista.Agregar(c);
            Response.Redirect($"Catalogo.aspx");
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Catalogo.aspx");
        }
    }
}