using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZPRO.PublicSiteController;
using ZPRO.Model;
using System.Configuration;

namespace ProjectZ.PublicSite
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                /* Put all PageLoad code here. */
            }


            // The 'GetUsers' function returns List<UserModel>

            UserListController con = new UserListController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            rUsers.DataSource = con.GetUsers();
            rUsers.DataBind();
        }


        protected void bDeleteUser_Click(object sender, EventArgs e)

        {
            Button bDeleteUser = (Button)sender;
            // Get the value from the Command Argument

            int userToDelete_UserID = int.Parse(bDeleteUser.CommandArgument);
            // Call the DeleteUser function in the UserListController class

        }
    }
}