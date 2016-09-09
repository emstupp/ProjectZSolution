using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.SQLDBDataAccess;

namespace ZPRO.PublicSiteController
{
    public class ZStatisticController : _BaseController
    {
        public ZStatisticController(string connectionString) : base(connectionString) { }


        public void InsertZ(ZStat z)
        {
            ZStatDataAccess zda = new ZStatDataAccess(SqlConConnectionString);
            zda.InsertZ(z);
        }


        public void InsertSample(Sample s)
        {
            SampleDataAccess sampda = new SampleDataAccess(SqlConConnectionString);
            sampda.InsertSample(s);
        }


        public void InsertObservation(Observation obs)
        {
            ObservationDataAccess obda = new ObservationDataAccess(SqlConConnectionString);
            obda.InsertObservation(obs);
        }



        public List<Observation> GetObservations()
        {
            
            ObservationDataAccess obda = new ObservationDataAccess(SqlConConnectionString);
            return obda.GetObservations();
            
        }
    }
}
