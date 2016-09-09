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
    public partial class CreateAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildScheduleController con = new BuildScheduleController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            ddlCourseList.DataSource = con.GetCourses(int.Parse(Session["CurrentUser_UserID"].ToString()));
            ddlCourseList.DataBind();
        }

        protected void bAddAssignment_Click(object sender, EventArgs e)
        {
            Assignment a = new Assignment();

            a.CourseID = int.Parse(ddlCourseList.SelectedValue);
            a.Name = tbHWName.Text;
            a.DueDate = DateTime.Parse(tbDueDate.Text);
            a.Type = rbHWType.SelectedValue;
        }
    }
}