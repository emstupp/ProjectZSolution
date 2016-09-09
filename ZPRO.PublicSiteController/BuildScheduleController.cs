using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.SQLDBDataAccess;

namespace ZPRO.PublicSiteController
{
    public class BuildScheduleController : _BaseController
    {
        public BuildScheduleController(string connectionString) : base(connectionString) { }


        public void InsertCourse(Course c)
        {
            CourseDataAccess da = new CourseDataAccess(SqlConConnectionString);
            da.InsertCourse(c);
        }

        public void DeleteCourse (int courseID)
        {
            CourseDataAccess da = new CourseDataAccess(SqlConConnectionString);
            da.DeleteCourse(courseID);
        }

        public List<Course> GetCourses(int userID)
        {
            CourseDataAccess da = new CourseDataAccess(SqlConConnectionString);
            return da.GetCourses(userID);
        }
    }
}
