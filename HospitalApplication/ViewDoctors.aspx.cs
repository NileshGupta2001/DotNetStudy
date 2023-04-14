
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace HospitalApplication
{
    public partial class ViewDoctors : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DbContext obj = new DbContext();
            var doctorlist = obj.GetDoctors();
            grdDoctorData.DataSource = doctorlist;
            grdDoctorData.DataBind();

        }

        protected void Edit_Data(object sender, GridViewEditEventArgs e)
        {
            grdDoctorData.EditIndex = e.NewEditIndex;
            DbContext obj = new DbContext();
            var doctorlist = obj.GetDoctors();
            grdDoctorData.DataSource = doctorlist;
            grdDoctorData.DataBind();
        }

        protected void grdDoctorData_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }



    
}