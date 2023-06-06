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
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DbContext obj = new DbContext();
                var doctorlist = obj.GetEmployee();
                grdDoctorData.DataSource = doctorlist;
                grdDoctorData.DataBind();
            }

        }

        protected void InsertEmployee(object sender, EventArgs e)
        {
            EmployeeModel employee = new EmployeeModel();
            DbContext obj = new DbContext();
            string temp = Phone.Text;
            if (temp.Length != 10)
            {
                lblmsg.Text = "Invalid Phone Number";
                lblmsg.Visible = true;
            }
            else
            {
                employee.EmployeeID = int.Parse(ID.Text);
                
                
                employee.EmployeeContact = Phone.Text;
                employee.EmployeeName = Name.Text;
                employee.EmployeeAdress = Address.Text;
                employee.DOB = Dob.SelectedDate;
                obj.AddEmployee(employee);
            }
            
        }


    }
}