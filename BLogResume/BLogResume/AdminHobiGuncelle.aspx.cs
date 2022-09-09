using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = Convert.ToString(x);

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_HOBITableAdapter dt = new DataSet1TableAdapters.TBL_HOBITableAdapter();
                TxtHobi.Text = dt.HobiDoldur(Convert.ToInt16(x))[0].HOBI;

            }


        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HOBITableAdapter dt2 = new DataSet1TableAdapters.TBL_HOBITableAdapter();
            dt2.HobibGuncelle(TxtHobi.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("AdminHobiler.Aspx");
        }
    }
}