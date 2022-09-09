using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminOdulEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_ODULLERTableAdapter dt = new DataSet1TableAdapters.TBL_ODULLERTableAdapter();
            dt.OdulEkle(TxtOdul.Text);
            Response.Redirect("AdminOduller.Aspx");
        }
    }
}