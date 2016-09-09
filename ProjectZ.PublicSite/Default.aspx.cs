using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectZ.PublicSite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                /* Put all PageLoad code here. */
            }

            if (Session["CurrentUser_UserID"] == null)
            {
                bFindZstat.Visible = false;

            } else if (Session["CurrentUser_UserID"] != null)
            {
                bLogin.Visible = false;
                bSignUp.Visible = false;
            }

        }



        protected void bFindZstat_MouseHover(object sender, EventArgs e)
        {
            this.bFindZstat.BackColor = System.Drawing.Color.Blue;
            this.bFindZstat.ForeColor = System.Drawing.Color.White;
        }




        protected void bLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void bSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }

        protected void bFindZstat_Click(object sender, EventArgs e)
        {
            Response.Redirect("ZStatistic.aspx");
        }

        protected void bFindTstat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TStatistic.aspx");
        }
    }
}