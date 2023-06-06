using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalApplication
{
    public partial class ViewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void SearchCall(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedValue=="Name")
            {

                SearchByNameText.Visible = true;
                SearchByNameBtn.Visible = true;
            }


        }

        protected void SearchByName(object sender, EventArgs e )
        {
            string name = SearchByNameText.Text;
            DbContext obj = new DbContext();
            var emplist = obj.SearchEmployeeByName(name);
            grdDoctorData.DataSource = emplist;
            grdDoctorData.DataBind();


        }
    }
}