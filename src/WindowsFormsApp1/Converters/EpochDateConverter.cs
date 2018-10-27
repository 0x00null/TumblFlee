using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1.Converters
{
    public class EpochDateConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
    {
        private static DateTime Epoch = new DateTime(1970, 01, 01);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Epoch.AddSeconds((Int64)reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
