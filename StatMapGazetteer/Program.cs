//using Helpers;
//using Newtonsoft.Json;
//using RoundManagamentAPI.Data.Helpers;

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

            string path = "https://s1.statmap.co.uk/gazetteers/bla_gazetteer/suggest?token=719dcaebad09b3a8d0eb78b03d75963c&searchedTerm=39%20BB1%205qy";
            client.DefaultRequestHeaders.Accept.Clear();
            client.BaseAddress = new Uri("https://s1.statmap.co.uk/gazetteers/bla_gazetteer/suggest?token=719dcaebad09b3a8d0eb78b03d75963c&searchedTerm=");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(path);
            Console.WriteLine(response);


        }
    }
}
