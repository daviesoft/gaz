//using Helpers;
//using Newtonsoft.Json;
//using RoundManagamentAPI.Data.Helpers;

using Newtonsoft.Json;
using StatMapGazetteer.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoundManagement.DCPPullRequest
{
    public class Program
    {
        private static readonly HttpClient client = new();

        static async Task Main(string[] args)
        {
            string postcode = args[0];
            string pathForIds = "https://s1.statmap.co.uk/gazetteers/bla_gazetteer/suggest?token=719dcaebad09b3a8d0eb78b03d75963c&searchedTerm=" + postcode;
            string pathForAddresses = "https://s1.statmap.co.uk/gazetteers/bla_gazetteer/";
            string suffixUrl = "?token=719dcaebad09b3a8d0eb78b03d75963c";

            client.DefaultRequestHeaders.Accept.Clear();
            //client.BaseAddress = new Uri("https://s1.statmap.co.uk/gazetteers/bla_gazetteer/suggest?token=719dcaebad09b3a8d0eb78b03d75963c&searchedTerm=");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(pathForIds);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<Gazetteer>(responseBody);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //Console.WriteLine(responseBody);
            foreach (var id in results.ids)
            {
                Console.WriteLine("Returning details for:" + id);
                response.EnsureSuccessStatusCode();
                HttpResponseMessage response2 = await client.GetAsync(pathForAddresses + id + suffixUrl);
                string responseBody2 = await response2.Content.ReadAsStringAsync();
                var results2 = JsonConvert.DeserializeObject<Address>(responseBody2);
                var address = JsonConvert.DeserializeObject<Record>(results2.record);
                Console.WriteLine(address.UPRN + " - " + address.GEO_SINGLE_ADDRESS_LABEL + " - " + address.STREET_DESCRIPTOR);
            }
        }
    }
}
