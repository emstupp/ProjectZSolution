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
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bUpdate_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.UserID = int.Parse(Session["CurrentUser_UserID"].ToString());

            
            UpdatePasswordController con = new UpdatePasswordController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            user.Password = tbNewPass.Text;
            con.UpdatePassword(user);
            con.EncryptPassword(tbNewPass.Text);

            Response.Redirect("UpdateUser.aspx", false);
        }
    }
}