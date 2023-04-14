using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace HospitalApplication
{
    public partial class AddDoctor : System.Web.UI.Page
    {
        string cs = @"server = DESKTOP-QG50OON\SQLEXPRESS;initial catalog = Doctor; integrated security = true";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Record(object sender, EventArgs e)
        {
            string msg = string.Empty;
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(SpecialityLst.SelectedValue) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox4.Text))
            {
                msg = "All Fields are required."; 
            }
            else
            {
                DoctorModel doctorModel = new DoctorModel();
                doctorModel.Name = TextBox1.Text;
                doctorModel.Speciality = SpecialityLst.SelectedValue;
                doctorModel.Years_of_Exp = int.Parse(TextBox3.Text);
                doctorModel.Gender = TextBox4.Text;
                DbContext obj = new DbContext();
                if (obj.AddDoctor(doctorModel))
                {
                    msg = "Successfully Added In The Database";
                }
                else
                {
                    msg = "Not able to add";
                }
                    lblmsg.Text = msg;
                    lblmsg.Visible = true;
                }
            }

        
    }
    }
