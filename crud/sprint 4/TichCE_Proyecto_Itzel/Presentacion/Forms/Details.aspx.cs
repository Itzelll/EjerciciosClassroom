using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Forms
{
    public partial class Details : System.Web.UI.Page
    {
        NegocioContratos lista = new NegocioContratos();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"] ?? "1");
            Contratos c = new Contratos();
            c = lista.Consultar(id);

            lblID.Text = id.ToString();
            lblcliente.Text = c.cliente.ToString();
            lbltipo.Text = c.tipoContrato.ToString();
            lblinicio.Text = c.fechaInicio.ToString();
            lblfinal.Text = c.fechaFin.ToString();
            lblmonto.Text = c.monto.ToString();
            lbldesc.Text = c.descripcion;
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Catalogo.aspx");
        }
    }
}