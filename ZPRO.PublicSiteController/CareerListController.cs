using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.BenobeDataAccess;

namespace ZPRO.PublicSiteController
{
    public class CareerListController : _BaseController
    {
        public CareerListController(string connectionString) : base(connectionString) { }

        public List<CareerModel> GetCareers(string url, string accessKey, string searchtext)
        {
            
            CareerDataAccess carda = new CareerDataAccess(url, accessKey);
            return carda.GetCareers(searchtext);
        }
        
        
    }
}
