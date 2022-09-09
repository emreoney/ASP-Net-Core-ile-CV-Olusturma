using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dt = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
            Repeater1.DataSource = dt.DeneyimlerimListele();
            Repeater1.DataBind();
        }
    }
}