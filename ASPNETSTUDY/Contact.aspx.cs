using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETSTUDY
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "abc";
            // if(Request.QueryString["name"] != null)
            //{
            //  lblName.Text=Request.QueryString["name"].ToString();
            //}

            //if (Request.Cookies["name"]!=null)
            //{
            //    lblName.Text=Request.Cookies["name"].Value;
            //}

            if (Session["name"]!=null)
            {
                lblName.Text = Session["name"].ToString();
            }
        }
    }
}