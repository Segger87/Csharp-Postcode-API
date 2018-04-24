using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Postcode
{
    class PostCodeApiCalls
    {
        public PostCodeDetails GetPostCodeDetails(string postcode)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var Client = new RestClient("http://api.postcodes.io/");
            var request = new RestRequest("postcodes/" + postcode, Method.GET);
            var postCodeData = Client.Execute<PostCodeAPIResponse>(request);
            return postCodeData.Data.Result;
        }
    }

  
        public class PostCodeAPIResponse
        {
            public PostCodeDetails Result { get; set; }
        }

        public class PostCodeDetails
        {
            public override string ToString() { return string.Format("Country = {0}, Region = {1}, Parish = {2} Long = {3}, Lat = {4}", Country, Region, Parish, Longitude, Latitude);  }
            public string Country { get; set; }
            public string Region { get; set; }
            public string Parish { get; set; }
            public string Longitude { get; set; }
            public string Latitude { get; set; }
        }
}
