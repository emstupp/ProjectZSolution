using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.SQLDBDataAccess;

namespace ZPRO.PublicSiteController
{
    public class WebServiceController : _BaseController
    {
        public WebServiceController(string connectionString) : base(connectionString) { }


       
        public List<Sample> GetSamples()
        {
            SampleDataAccess samda = new SampleDataAccess(SqlConConnectionString);
            return samda.GetSamples();
        }
        

    }
}
