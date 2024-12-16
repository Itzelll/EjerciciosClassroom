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
    public partial class Detalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"] ?? "1");

            ADOGruposComerciales lstGrupos = new ADOGruposComerciales();
            GruposComerciales objGrupo = lstGrupos.Consultar(id);

            lblid.Text = id.ToString();
            lblnombre.Text = objGrupo.nombre.ToString();
            lbldir.Text = objGrupo.direccion.ToString();
            lblrfc.Text = objGrupo.rfc.ToString();
            lbltel.Text = objGrupo.telefono.ToString();
            lblcorreo.Text = objGrupo.email.ToString();
        }

        protected void btnIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Index.aspx");
        }
    }
}