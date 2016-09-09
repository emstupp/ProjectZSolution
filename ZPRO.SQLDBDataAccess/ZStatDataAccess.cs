using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;

namespace ZPRO.SQLDBDataAccess
{
    public class ZStatDataAccess : DBAccess
    {
        public ZStatDataAccess(string connectionString) : base(connectionString) { }

        // A function that inserts a User into the database.
        public void InsertZ(ZStat newZStat)
        {
            // Declare a new variable. Variable name is ‘sSQL’. Datatype is ‘string’.
            string sSQL = "";

            // Define the value for the ‘sSQL’ string variable.
            // Notice that this text is a SQL Query.
            sSQL += " INSERT INTO [ZStat] ";

            // More columns will need to be added, depending on how many columns you have in your User table.
            // In this line, you need ALL the columns from your User table.

            // The word ‘Password’ is in brackets because it is a reserved word in SQL. 
            // We are hijacking that word and using it for our own purposes, so we need to put it in brackets.
            // Normally, SQL would try to interpret the word 'Password' differently than how we're using it.

            sSQL += " (CriticalZ, ObservedZ, Alpha, TwoTailed) ";
            sSQL += " Values ";
            // The ‘@’ sign is a SQL Variable. It is connected to a SqlParameter (below).
            // This line needs to exactly match the list of columns in the User table.
            sSQL += " (@CriticalZ, @ObservedZ, @Alpha, @TwoTailed) ";

            // Declare a new variable. Variable name is ‘sqlcomm’. Datatype is ‘SqlCommand’.
            SqlCommand sqlcomm = new SqlCommand();
            // Assign a value to the CommandText property.
            sqlcomm.CommandText = sSQL;

            // This SqlParameter constructor takes two arguments as input values.
            // Argument One: SQL Variable Name
            // Argument Two: Variable Value
            // The SqlParameter handles the declaration of the actual SQL Parameter in the T-SQL.
            SqlParameter sqlparam = new SqlParameter("CriticalZ", newZStat.CriticalZ);
            sqlcomm.Parameters.Add(sqlparam);

            // Notice that there is one ‘SqlParameter’ variable for each variable used in the SQL Query
            // More SqlParameter variables will need to be added for additional SQL variables.
            sqlparam = new SqlParameter("ObservedZ", newZStat.ObservedZ);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("Alpha", newZStat.Alpha);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("TwoTailed", newZStat.TwoTailed);
            sqlcomm.Parameters.Add(sqlparam);

            // Execute the query.
            ExecNonQuery(sqlcomm);
        }


        
    }
}
