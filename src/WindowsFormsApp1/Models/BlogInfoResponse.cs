using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class BlogInfoResponse
    {
        [JsonProperty("blog")]
        public BlogInfo Blog { get; set; }
    }
}
