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
            Response.Redirect($"Create.aspx");
        }

        private void CargarGridView()
        {
            List<Contratos> list = _lista.Consultar();

            gvContratos.DataSource = list.ToList();
            gvContratos.DataBind();
        }

        protected void gvContratos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvContratos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        protected void gvContratos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Page")
            {
                int numRenglon = Convert.ToInt32(e.CommandArgument);
                GridViewRow renglon = gvContratos.Rows[numRenglon];
                TableCell celda = renglon.Cells[0]; //extraer la celda

                int id = Convert.ToInt32(celda.Text);

                switch (e.CommandName)
                {
                    case "btnDetalles":
                        Response.Redirect($"Details.aspx?id={id}");
                        break;
                    case "btnEditar":
                        Response.Redirect($"Edit.aspx?id={id}");
                        break;
                    case "btnEliminar":
                        Response.Redirect($"Delete.aspx?id={id}");
                        break;
                }
            }
            else
            {
                return;
            }
        }
    }
}