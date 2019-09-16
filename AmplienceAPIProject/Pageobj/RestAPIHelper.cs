using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplienceAPI.Pageobj
{
    public static class RestAPIHelper
    {
        public static  RestClient client;
        public static RestRequest restRequest;

        public static string baseurl = "https://api.github.com/";


        public static RestClient seturl(string endpoint)
        {
            var url = Path.Combine(baseurl, endpoint);
                return client = new RestClient(url);
        }

        public static RestRequest GetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestRequest GetRequest(string userid)
        {
            var resource = userid;
            var restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;

        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }

                
    }
}
