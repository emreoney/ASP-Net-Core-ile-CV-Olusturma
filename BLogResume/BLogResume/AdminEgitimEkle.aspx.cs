using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_EGITIMTableAdapter dt = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            dt.EgitimEkle(TxtBaslik.Text, TxtAltbaslik.Text, TxtAciklama.Text, TxtGnot.Text, TxtTarih.Text);
            Response.Redirect("AdminEgitim.Aspx"):
        }
    }
}