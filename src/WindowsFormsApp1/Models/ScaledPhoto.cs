using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ScaledPhoto
    {
        [JsonProperty("url")]
        public String Url { get; set; }

        [JsonProperty("width")]
        public Int32 Width { get; set; }

        [JsonProperty("height")]
        public Int32 Height { get; set; }
    }
}
