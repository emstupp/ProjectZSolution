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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                /* Put all PageLoad code here. */
            }
        }

        protected void bSubmit_Click(object sender, EventArgs e)
        {
            
            UserModel newUser = new UserModel();
            newUser.FirstName = tbFirstName.Text;
            newUser.LastName = tbLastName.Text;
            newUser.Email = tbEmail.Text;
            newUser.Password = tbPassword.Text;

            CreateUserController con = new CreateUserController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            con.InsertUser(newUser);
            con.EncryptPassword(tbPassword.Text);

            Session["CurrentUser_UserID"] = newUser.UserID;
            Response.Redirect("Default.aspx", false);
        }
    }
}