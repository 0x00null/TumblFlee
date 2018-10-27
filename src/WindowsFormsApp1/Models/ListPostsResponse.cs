using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ListPostsResponse
    {
        [JsonProperty("blog")]
        public BlogInfo Blog { get; set; }

        [JsonProperty("posts")]
        public PostInfo[] Posts { get; set; }
    }
}
