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
    public class ObservationDataAccess : DBAccess
    {
        public ObservationDataAccess(string connectionString) : base(connectionString) { }

        public void InsertObservation(Observation newObs)
        {
            // Declare a new variable. Variable name is ‘sSQL’. Datatype is ‘string’.
            string sSQL = "";

            // Define the value for the ‘sSQL’ string variable.
            // Notice that this text is a SQL Query.
            sSQL += " INSERT INTO [Observation] ";

            // More columns will need to be added, depending on how many columns you have in your User table.
            // In this line, you need ALL the columns from your User table.

            // The word ‘Password’ is in brackets because it is a reserved word in SQL. 
            // We are hijacking that word and using it for our own purposes, so we need to put it in brackets.
            // Normally, SQL would try to interpret the word 'Password' differently than how we're using it.

            sSQL += " (Value) ";
            sSQL += " Values ";
            // The ‘@’ sign is a SQL Variable. It is connected to a SqlParameter (below).
            // This line needs to exactly match the list of columns in the User table.
            sSQL += " (@Value) ";

            // Declare a new variable. Variable name is ‘sqlcomm’. Datatype is ‘SqlCommand’.
            SqlCommand sqlcomm = new SqlCommand();
            // Assign a value to the CommandText property.
            sqlcomm.CommandText = sSQL;

            // This SqlParameter constructor takes two arguments as input values.
            // Argument One: SQL Variable Name
            // Argument Two: Variable Value
            // The SqlParameter handles the declaration of the actual SQL Parameter in the T-SQL.
            SqlParameter sqlparam = new SqlParameter("Value", newObs.Value);
            sqlcomm.Parameters.Add(sqlparam);


            // Execute the query.
            ExecNonQuery(sqlcomm);
        }





        public List<Observation> GetObservations()
        {
            List<Observation> ret = new List<Observation>();

            string sql = "SELECT Value FROM [Observation]";
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = sql;
            DataTable dt = ExecReader(sqlcomm);

            foreach (DataRow dr in dt.Rows)
            {
                Observation obs = new Observation();
                obs.ObservationID = int.Parse(dr["ObservationID"].ToString());
                obs.SampleID = int.Parse(dr["SampleID"].ToString());
                obs.Value = double.Parse(dr["Value"].ToString());
                ret.Add(obs);
            }

            return ret;
        }
    }
}
