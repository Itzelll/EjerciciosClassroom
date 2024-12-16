using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tich_WebFormADO_Estadios.ADO;
using Tich_WebFormADO_Estadios.Entidades;

namespace Tich_WebFormADO_Estadios.Forms
{
    public partial class Index : System.Web.UI.Page
    {
        ADOGruposComerciales _lstGrupos = new ADOGruposComerciales();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        protected void gvGrupos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Page")
            {
                int numRenglon = Convert.ToInt32(e.CommandArgument);
                GridViewRow renglon = gvGrupos.Rows[numRenglon];
                TableCell celda = renglon.Cells[0]; //extraer la celda

                int id = Convert.ToInt32(celda.Text);

                switch (e.CommandName)
                {
                    case "btnDetalles":
                        Response.Redirect($"Detalles.aspx?id={id}");
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

        protected void gvGrupos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvGrupos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        private void CargarGridView()
        {
            List<GruposComerciales> lista = _lstGrupos.Consultar();

            gvGrupos.DataSource = lista.ToList();
            gvGrupos.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Agregar.aspx");
        }
    }
}