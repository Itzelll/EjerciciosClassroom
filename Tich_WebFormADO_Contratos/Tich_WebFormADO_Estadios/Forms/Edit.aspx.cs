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
    public partial class Edit : System.Web.UI.Page
    {
        ADOGruposComerciales lstgrupos = new ADOGruposComerciales();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"] ?? "1");

                GruposComerciales obj = lstgrupos.Consultar(id);

                lblid.Text = id.ToString();
                tbnombre.Text = obj.nombre;
                tbdir.Text = obj.direccion;
                tbrfc.Text = obj.rfc;
                tbtel.Text = obj.telefono;
                tbcorreo.Text = obj.email;
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            GruposComerciales obj = new GruposComerciales();

            obj.id = int.Parse(Request.QueryString["id"] ?? "1");
            obj.nombre = tbnombre.Text;
            obj.direccion = tbdir.Text;
            obj.rfc = tbrfc.Text;
            obj.telefono = tbtel.Text;
            obj.email = tbcorreo.Text;

            lstgrupos.Actualizar(obj);
            Response.Redirect($"Index.aspx");
        }

        protected void btnIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Index.aspx");
        }
    }
}