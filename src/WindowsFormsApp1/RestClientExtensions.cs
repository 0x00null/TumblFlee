using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public static class RestClientExtensions
    {
        public static async Task<T> CallApi<T>(this RestClient client, IRestRequest req)
        {
            var response = await client.ExecuteTaskAsync(req);
            var apiResponse = JsonConvert.DeserializeObject<ApiResponse<T>>(response.Content);
            return apiResponse.Response;
        }
    }
}
