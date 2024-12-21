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
    public partial class Edit : System.Web.UI.Page
    {
        NegocioContratos lista = new NegocioContratos();
        Contratos c = new Contratos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"] ?? "1");
                c = lista.Consultar(id);

                tbid.Text = id.ToString();
                tbid.Enabled = false;
                tbcliente.Text = c.cliente.ToString();
                tbtipo.Text = c.tipoContrato.ToString();
                tbinicio.Text = c.fechaInicio.ToString("yyyy-MM-dd");
                tbfinal.Text = c.fechaFin.ToString("yyyy-MM-dd");
                tbmonto.Text = c.monto.ToString();
                tbdesc.Text = c.descripcion;
            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Catalogo.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                c.id = int.Parse(Request.QueryString["id"] ?? "1");
                c.cliente = int.Parse(tbcliente.Text);
                c.tipoContrato = int.Parse(tbtipo.Text);
                c.fechaInicio = DateTime.Parse(tbinicio.Text);
                c.fechaFin = DateTime.Parse(tbfinal.Text);
                c.monto = Decimal.Parse(tbmonto.Text);
                c.descripcion = tbdesc.Text;

                lista.Actualizar(c);
                Response.Redirect($"Catalogo.aspx");
            }
        }
    }
}