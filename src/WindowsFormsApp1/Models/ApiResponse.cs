using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Base class for all Tumblr API Responses
    /// </summary>
    public sealed class ApiResponse<T>
    {
        [JsonProperty("meta")]
        public ResponseMetadata Metadata { get; set; }

        [JsonProperty("response")]
        public T Response { get; set; }
    }
}
