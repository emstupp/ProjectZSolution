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
    public partial class BuildSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int currentUserID = int.Parse(Session["CurrentUser_UserID"].ToString());
            BuildScheduleController con = new BuildScheduleController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            rCourses.DataSource = con.GetCourses(currentUserID);
            rCourses.DataBind();
        }



        protected void bAddCourse_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Department = tbDepartment.Text;
            c.SectionNum = int.Parse(tbCourseNum.Text);
            c.Title = tbTitle.Text;
            c.Days = cbDays.SelectedValue;
            c.StartTime = DateTime.Parse(tbStartTime.Text);
            c.EndTime = DateTime.Parse(tbEndTime.Text);
            c.Professor = tbProfessor.Text;
            c.Credits = int.Parse(tbCredits.Text);
            c.UserID = int.Parse(Session["CurrentUser_UserID"].ToString());

            BuildScheduleController con = new BuildScheduleController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            con.InsertCourse(c);
        }



        protected void InsertCourse(Course c)
        {
            BuildScheduleController con = new BuildScheduleController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            con.InsertCourse(c);
        }


        //WORK IN PROGRESS
        protected void bDeleteCourse_Click(object sender, EventArgs e)
        {
            Button bDeleteCourse= (Button)sender;
            
            // Get the value from the Command Argument
            int courseToDelete_CourseID = int.Parse(bDeleteCourse.CommandArgument);


        }

        
    }
}