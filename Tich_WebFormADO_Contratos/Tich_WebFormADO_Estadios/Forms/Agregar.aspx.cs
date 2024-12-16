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
    public partial class Agregar : System.Web.UI.Page
    {
        ADOGruposComerciales lstgrupos = new ADOGruposComerciales();
        GruposComerciales objgrupo = new GruposComerciales();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Index.aspx");
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            objgrupo.nombre = tbnombre.Text;
            objgrupo.direccion = tbdir.Text;
            objgrupo.rfc = tbrfc.Text;
            objgrupo.telefono = tbtel.Text;
            objgrupo.email = tbcorreo.Text;

            lstgrupos.Agregar(objgrupo);
            Response.Redirect($"Index.aspx");
        }
    }
}