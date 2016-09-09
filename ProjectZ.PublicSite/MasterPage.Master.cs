using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectZ.PublicSite
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                /* Put all PageLoad code here. */
            }

            if (Session["CurrentUser_UserID"] == null)
            {
                hlCourses.Visible = false;
                hlLogout.Visible = false;
                hlChangeInfo.Visible = false;
            }

        }


        
    }
}