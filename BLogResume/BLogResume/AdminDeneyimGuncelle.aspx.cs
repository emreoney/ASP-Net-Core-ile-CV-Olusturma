using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = Convert.ToString(x);
            

            
            

            if(Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dt = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
                TxtBaslik.Text = dt.DeneyimDoldur(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslik.Text = dt.DeneyimDoldur(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = dt.DeneyimDoldur(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = dt.DeneyimDoldur(Convert.ToInt16(x))[0].TARIH;
               

            }




        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dt1 = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
            dt1.DeneyimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}