using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PhotoPostInfo
    {
        [JsonProperty("caption")]
        public String Caption { get; set; }

        [JsonProperty("photos")]
        public Photo[] Photos { get; set; }
    }
}
