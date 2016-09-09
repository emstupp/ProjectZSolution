using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ZPRO.PublicSiteController;
using ZPRO.Model;
using System.Configuration;

namespace ProjectZ.PublicSite
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://myzpro.azurewebsites.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Sample> GetSamples()
        {
            WebServiceController con = new WebServiceController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            return con.GetSamples();
        }

    }






        /*
        public double getCriticalZ()
        {
            WebServiceController con = new WebServiceController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            return con.getCriticalZ();
        }
        */
    
}
