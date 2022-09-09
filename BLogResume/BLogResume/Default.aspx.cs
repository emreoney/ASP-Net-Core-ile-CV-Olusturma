using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLogResume
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBL_HAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();


            DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dt2 = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimlerimListele();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBL_EGITIMTableAdapter dt3 = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBL_YETENEKLERTableAdapter dt4 = new DataSet1TableAdapters.TBL_YETENEKLERTableAdapter();
            Repeater4.DataSource = dt4.YetenekListele();
            Repeater4.DataBind();


            DataSet1TableAdapters.TBL_HOBITableAdapter dt5 = new DataSet1TableAdapters.TBL_HOBITableAdapter();
            Repeater5.DataSource = dt5.HobileriListsele();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBL_ODULLERTableAdapter dt6 = new DataSet1TableAdapters.TBL_ODULLERTableAdapter();
            Repeater6.DataSource = dt6.OdullerListele();
            Repeater6.DataBind();



        }
    }
}