using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminEgitim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_EGITIMTableAdapter dt = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            Repeater1.DataSource = dt.EgitimGetir();
            Repeater1.DataBind();
        }
    }
}