using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Converters;

namespace WindowsFormsApp1.Models
{
    public class PostInfo
    {
        [JsonExtensionData]
        private JObject _extensionData = null;

        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("type")]
        public String Type { get; set; }

        [JsonConverter(typeof(EpochDateConverter))]
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("post_url")]
        public String FullUrl { get; set; }

        [JsonProperty("short_url")]
        public String ShortUrl { get; set; }

        [JsonProperty("note_count")]
        public Int32 TotalNotes { get; set; }

        [JsonProperty("tags")]
        public String[] Tags { get; set; }

        [JsonProperty("reblogged_from_id")]
        public String RebloggedFrom { get; set; }

        [JsonProperty("source_url")]
        public String SourceUrl { get; set; }

        [JsonProperty("source_title")]
        public String SourceTitle { get; set; }

        public PhotoPostInfo AsPhoto()
        {
            return _extensionData.ToObject<PhotoPostInfo>();
        }
        
    }
}
