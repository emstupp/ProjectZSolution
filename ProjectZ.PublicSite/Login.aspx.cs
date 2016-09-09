using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZPRO.Model;
using ZPRO.PublicSiteController;

namespace ProjectZ.PublicSite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                /* Put all PageLoad code here. */
            }

            if (Session["CurrentUser_UserID"]!=null)
            {
                Response.Redirect("Default.aspx", false);
            }
        }

        protected void bSubmit_Click(object sender, EventArgs e)
        {
            LoginController con = new LoginController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());            
            con.LoginUser(tbEmail.Text, tbPassword.Text);
            con.EncryptPassword(tbPassword.Text);

            int userID = con.GetUserIDFromLogin(tbEmail.Text, tbPassword.Text);
            if (userID != 0)
            {
                Session["CurrentUser_UserID"] = userID;
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                labSubmit.Text = "No such user...need an account?";
            }

            
        }
    }

}
