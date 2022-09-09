using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class YetenekListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_YETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBL_YETENEKLERTableAdapter();
            Repeater1.DataSource = dt.YetenekListele();
            Repeater1.DataBind();
        }
    }
}