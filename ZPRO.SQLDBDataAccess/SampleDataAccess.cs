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
    public class SampleDataAccess : DBAccess
    {
        public SampleDataAccess(string connectionString) : base(connectionString) { }

        // A function that inserts a User into the database.
        public void InsertSample(Sample newSample)
        {
            // Declare a new variable. Variable name is ‘sSQL’. Datatype is ‘string’.
            string sSQL = "";

            // Define the value for the ‘sSQL’ string variable.
            // Notice that this text is a SQL Query.
            sSQL += " INSERT INTO [Sample] ";

            // More columns will need to be added, depending on how many columns you have in your User table.
            // In this line, you need ALL the columns from your User table.

            // The word ‘Password’ is in brackets because it is a reserved word in SQL. 
            // We are hijacking that word and using it for our own purposes, so we need to put it in brackets.
            // Normally, SQL would try to interpret the word 'Password' differently than how we're using it.

            sSQL += " (SampleMean, PopulationMean, SampleStDev, SampleSize) ";
            sSQL += " Values ";
            // The ‘@’ sign is a SQL Variable. It is connected to a SqlParameter (below).
            // This line needs to exactly match the list of columns in the User table.
            sSQL += " (@SampleMean, @PopulationMean, @SampleStDev, @SampleSize) ";

            // Declare a new variable. Variable name is ‘sqlcomm’. Datatype is ‘SqlCommand’.
            SqlCommand sqlcomm = new SqlCommand();
            // Assign a value to the CommandText property.
            sqlcomm.CommandText = sSQL;

            // This SqlParameter constructor takes two arguments as input values.
            // Argument One: SQL Variable Name
            // Argument Two: Variable Value
            // The SqlParameter handles the declaration of the actual SQL Parameter in the T-SQL.
            SqlParameter sqlparam = new SqlParameter("SampleMean", newSample.SampleMean);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("PopulationMean", newSample.PopulationMean);
            sqlcomm.Parameters.Add(sqlparam);

            // Notice that there is one ‘SqlParameter’ variable for each variable used in the SQL Query
            // More SqlParameter variables will need to be added for additional SQL variables.
            sqlparam = new SqlParameter("SampleStDev", newSample.SampleStDev);
            sqlcomm.Parameters.Add(sqlparam);

            sqlparam = new SqlParameter("SampleSize", newSample.SampleSize);
            sqlcomm.Parameters.Add(sqlparam);

            //sqlparam = new SqlParameter("StdErrorMean", newSample.StdErrorMean);
            //sqlcomm.Parameters.Add(sqlparam);

            // Execute the query.
            ExecNonQuery(sqlcomm);
        }


        public List<Sample> GetSamples()
        {
            List<Sample> samples = new List<Sample>();
            string ssql = "";
            ssql += "SELECT * FROM [Sample]";

            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = ssql;
            DataTable dt = ExecReader(sqlcomm);

            foreach (DataRow dr in dt.Rows)
            {
                Sample s = new Sample();
                s.SampleID = int.Parse(dr["SampleID"].ToString());
                s.StatisticID = int.Parse(dr["StatisticID"].ToString());
                s.PopulationMean = double.Parse(dr["PopulationMean"].ToString());
                s.SampleMean = double.Parse(dr["SampleMean"].ToString());
                s.SampleStDev = double.Parse(dr["SampleStDev"].ToString());
                s.SampleSize = int.Parse(dr["SampleSize"].ToString());

                samples.Add(s);

            }

            return samples;

        }
    }
}
