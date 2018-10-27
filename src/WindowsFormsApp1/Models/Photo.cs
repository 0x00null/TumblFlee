using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Photo
    {
        [JsonProperty("caption")]
        public String Caption { get; set; }

        [JsonProperty("alt_sizes")]
        public ScaledPhoto[] Sizes { get; set; }
    }
}
