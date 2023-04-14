using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETSTUDY
{
    public partial class About : Page
    {
        int i = 0;

        string name=string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                i = 10;
                name = "Nilesh";
                HiddenField1.Value=name;
            }
        }

        //protected void TextBox1_TextChanged(object sender, EventArgs e)
        //{
            
        //}
        
        //protected void Page_Unload(object sender, EventArgs e)
        //{
        //    if (IsPostBack)
        //    {

        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            //txtName.Text = i.ToString();
            //txtName.Text = HiddenField1.Value;
            //name = "ranveer";
            //State Management
            //ViewState
            //ViewState["Name"] = "ranveer";
            //Response.Redirect("Contact.aspx?name="+txtName.Text);
            int i = 0;
            int b = 2 / i;
            Response.Cookies["name"].Value =txtName.Text;
            Session["name"] = txtName.Text;
            Response.Redirect("Contact.aspx");
            

        }
    }
}