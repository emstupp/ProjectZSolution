using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;

namespace ZPRO.BenobeDataAccess
{
    public class CareerDataAccess
    {

        // This is the DataAccess constructor
        public CareerDataAccess(string url, string accessKey)
        {
            // Save the values that get passed into the constructor.
            _Url = url;
            _AccessKey = accessKey;
        }
        private string _Url;
        private string _AccessKey;




        // 'searchText' is what the user is searching for in a career
        public List<CareerModel> GetCareers(string searchText)
        {
            // Create a HTTP Request instance
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(_Url);

            // Indicate that this is a JSON request
            request.ContentType = "application/json";

            // Indicate that this is a POST request
            request.Method = "POST";

            // Add your API credentials to the Request Header
            request.Headers.Add("x-access-token: " + _AccessKey);

            // Add your search text to the request stream
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write("{\"query\":\"" + searchText + "\"}"); streamWriter.Flush(); streamWriter.Close();
            }

            // Get the response from the server
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseJSON = "";
            if (response.StatusCode == HttpStatusCode.OK)
            {
                responseJSON = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }

            // Close the response
            response.Close();



            // Parse the JSON response
            dynamic jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject(responseJSON);


            // Strongly-typed Model that will be returned from this function
            List<CareerModel> ret = new List<CareerModel>();

            // Convert the weakly-typed JSON to a strongly-typed Model
            foreach (dynamic j in jsonObject.careers)
            {
                CareerModel career = new CareerModel();
                career.position = j.position;
                career.cid = j.cid;
                career.label = j.label;
                career.isgreen = j.isgreen;
                career.imagename = j.imagename;
                career.desc = j.desc;

                ret.Add(career);
            }


            return ret;
        }
    }
}
