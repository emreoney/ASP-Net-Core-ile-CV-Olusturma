using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminOdulSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBL_ODULLERTableAdapter dt = new DataSet1TableAdapters.TBL_ODULLERTableAdapter();
            dt.OdulSil(Convert.ToInt16(x));
            Response.Redirect("AdminOduller.Aspx");
        }
    }
}