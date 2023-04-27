
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
        {   if (!IsPostBack)
            {
                DbContext obj = new DbContext();
                var doctorlist = obj.GetDoctors();
                grdDoctorData.DataSource = doctorlist;
                grdDoctorData.DataBind();
            }

        }

        protected void Edit_Data(object sender, GridViewEditEventArgs e)
        {
            grdDoctorData.EditIndex = e.NewEditIndex;
            DbContext obj = new DbContext();
            var doctorlist = obj.GetDoctors();
            grdDoctorData.DataSource = doctorlist;
            grdDoctorData.DataBind();
            

        }

        protected void grdDoctorData_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Delete")
            {
                var ID = e.CommandArgument;
                DbContext obj = new DbContext();
                obj.Delete(ID.ToString());
                var doctorlist = obj.GetDoctors(); 
                grdDoctorData.DataSource = doctorlist;
                grdDoctorData.DataBind();
                Response.Redirect(Request.RawUrl, true);
            }

            if(e.CommandName=="Edit")
            {

            }
        }
    }



    
}