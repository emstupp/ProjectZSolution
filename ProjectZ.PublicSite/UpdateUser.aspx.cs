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
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Page.IsPostBack == false)
            {
                UserModel user = new UserModel();
                user.UserID = int.Parse(Session["CurrentUser_UserID"].ToString());

                labFirstName.Text = user.FirstName;
                labLastName.Text = user.LastName;
                labEmail.Text = user.Email;
            }

        }

        protected void bUpdate_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.UserID = int.Parse(Session["CurrentUser_UserID"].ToString());

            if (tbFirstName.Text!=null)
            {
                user.FirstName = tbFirstName.Text;
                labFirstName.Text = tbFirstName.Text;
            }

            if(tbLastName.Text != null)
            {
                user.LastName = tbLastName.Text;
                labLastName.Text = tbLastName.Text;
            }

            if(tbEmail.Text != null)
            {
                user.Email = tbEmail.Text;
                labEmail.Text = tbEmail.Text;
            }


            UpdateUserController con = new UpdateUserController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            con.UpdateUser(user);
            Response.Redirect("UpdateUser.aspx", false);
        }
    }
}