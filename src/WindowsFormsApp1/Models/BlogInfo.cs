using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Converters;

namespace WindowsFormsApp1.Models
{
    public class BlogInfo
    {
        [JsonProperty("title")]
        public String Title { get; set; }

        [JsonProperty("total_posts")]
        public Int32 TotalPosts { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonConverter(typeof(EpochDateConverter))]
        [JsonProperty("updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("description")]
        public String Description { get; set; }

        [JsonProperty("is_nsfw")]
        public Boolean IsNsfw { get; set; }

        [JsonProperty("ask")]
        public Boolean AskEnabled { get; set; }

        [JsonProperty("ask_anon")]
        public Boolean AskAnonEnabled { get; set; }
    }
}
