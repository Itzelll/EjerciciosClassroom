using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Catalogo : System.Web.UI.Page
    {
        NegocioContratos _lista = new NegocioContratos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"");
        }

        private void CargarGridView()
        {
            List<Contratos> list = _lista.Consultar();

            gvContratos.DataSource = list.ToList();
            gvContratos.DataBind();
        }
    }
}