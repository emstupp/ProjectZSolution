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
    public class AssignmentDataAccess : DBAccess
    {
        public AssignmentDataAccess(string connectionString) : base(connectionString) { }


        public void InsertAssignment(Assignment newHW)
        {
            string sSQL = "";
            sSQL += " INSERT INTO [Assignment] ";


            sSQL += " (Type, Name, DueDate, Description) ";
            sSQL += " Values ";

            sSQL += " (@Type, @Name, @DueDate, @Description) ";


            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sSQL;


            SqlParameter sqlparam = new SqlParameter("Type", newHW.Type);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Name", newHW.Name);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("DueDate", newHW.DueDate);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Description", newHW.Description);
            sqlcomm.Parameters.Add(sqlparam);

            ExecNonQuery(sqlcomm);
        }


        public void UpdateAssignment(Assignment a)
        {
            string sSQL = "";
            sSQL += " UPDATE [Assignment] SET Class = @Class, Type = @Type, Name = @Name, DueDate = @DueDate, Description = @Description";
            sSQL += " WHERE AssignmentID = " + a.AssignmentID.ToString();


            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sSQL;

            SqlParameter sqlparam = new SqlParameter("Type", a.Type);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Name", a.Name);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("DueDate", a.DueDate);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Description", a.Description);
            sqlcomm.Parameters.Add(sqlparam);


            // Execute the query.
            ExecNonQuery(sqlcomm);
        }



        public List<Assignment> GetAssignments()
        {

            // This is a SQL Query
            string sql = " SELECT Class, Name, DueDate FROM [Assignment] ";
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sql;

            // Execute the SQL query
            DataTable dt = ExecReader(sqlcomm);

            // This is the variable that will be returned from the function.
            List<Assignment> homeworks = new List<Assignment>();

            // Go through each row in the datatable.
            foreach (DataRow dr in dt.Rows)
            {

                // Get the data from the datatable
                Assignment hw = new Assignment();
                hw.CourseID = int.Parse(dr["CourseID"].ToString());
                hw.Name = dr["Name"].ToString();
                hw.DueDate = DateTime.Parse(dr["DueDate"].ToString());

                // Add this User to the list
                homeworks.Add(hw);
            }

            return homeworks;
        }
    }
}
