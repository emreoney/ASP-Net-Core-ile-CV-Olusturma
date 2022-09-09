using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.TBL_YETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBL_YETENEKLERTableAdapter();
            dt.YetenekEkle(TxtYetenek.Text);
            Response.Redirect("AdminYetenekler.Aspx");
        }
    }
}