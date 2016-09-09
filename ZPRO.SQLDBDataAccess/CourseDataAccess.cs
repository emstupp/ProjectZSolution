using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;

namespace ZPRO.SQLDBDataAccess
{
    public class CourseDataAccess : DBAccess
    {
        public CourseDataAccess(string connectionString) : base(connectionString) { }


        public void InsertCourse(Course newCourse)
        {
            string sSQL = "";
            sSQL += " INSERT INTO [Course] ";


            sSQL += " (Professor, Department, SectionNum, Title, Days, StartTime, EndTime, Credits, UserID) ";
            sSQL += " Values ";

            sSQL += " (@Professor, @Department, @SectionNum, @Title, @Days, @StartTime, @EndTime, @Credits, @UserID) ";


            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sSQL;


            SqlParameter sqlparam = new SqlParameter("Professor", newCourse.Professor);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Department", newCourse.Department);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("SectionNum", newCourse.SectionNum);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Title", newCourse.Title);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Days", newCourse.Days);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("StartTime", newCourse.StartTime);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("EndTime", newCourse.EndTime);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Credits", newCourse.Credits);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("UserID", newCourse.UserID);
            sqlcomm.Parameters.Add(sqlparam);

            ExecNonQuery(sqlcomm);
        }



        public void UpdateCourse(Course c)
        {
            string sSQL = "";
            sSQL += " UPDATE [Course] SET Professor = @Professor, ";
            sSQL += " Department = @Department, ";
            sSQL += " SectionNum = @SectionNum, ";
            sSQL += " Title = @Title, ";
            sSQL += " Days = @Days, ";
            sSQL += " StartTime = @StartTime, ";
            sSQL += " EndTime = @EndTime, ";

            sSQL += " WHERE CourseID = " + c.CourseID.ToString();


            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sSQL;

            SqlParameter sqlparam = new SqlParameter("Professor", c.Professor);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Department", c.Department);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("SectionNum", c.SectionNum);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Title", c.Title);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Days", c.Days);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("StartTime", c.StartTime);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("EndTime", c.EndTime);
            sqlcomm.Parameters.Add(sqlparam);


            // Execute the query.
            ExecNonQuery(sqlcomm);
        }


        public void DeleteCourse(int courseID)
        {
            string sql = "DELETE FROM [Course] ";
            sql += " WHERE CourseID = @CourseID";
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sql;

            SqlParameter sqlparam = new SqlParameter("CourseID", courseID.ToString());
            sqlcomm.Parameters.Add(sqlparam);

            ExecNonQuery(sqlcomm);
        }


        public List<Course> GetCourses(int userID)
        {

            // This is a SQL Query
            string sql = " SELECT Department, SectionNum, Days, StartTime, EndTime FROM [Course] ";
            sql += " WHERE UserID = @UserID";
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sql;

            SqlParameter sqlparam = new SqlParameter("UserID", userID.ToString());
            sqlcomm.Parameters.Add(sqlparam);

            // Execute the SQL query
            DataTable dt = ExecReader(sqlcomm);

            // This is the variable that will be returned from the function.
            List<Course> classes = new List<Course>();

            // Go through each row in the datatable.
            foreach (DataRow dr in dt.Rows)
            {

                // Get the data from the datatable
                Course c = new Course();

                c.Department = dr["Department"].ToString();
                c.SectionNum = int.Parse(dr["SectionNum"].ToString());
                c.Days = dr["Days"].ToString();
                c.StartTime = DateTime.Parse(dr["StartTime"].ToString()); ;
                c.EndTime = DateTime.Parse(dr["EndTime"].ToString());

                classes.Add(c);
            }

            return classes;
        }
    }
}
