using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Auraxis.Net.Helpers
{
    internal class HistoryArrayConverter : JsonConverter<int[]>
    {
        public override int[] ReadJson(JsonReader reader, Type objectType, int[] existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var j = (JObject)serializer.Deserialize(reader);
            return j.PropertyValues().Select(Extensions.Value<int>).ToArray();
        }

        public override void WriteJson(JsonWriter writer, int[] value, JsonSerializer serializer) => throw new NotImplementedException();
    }
}
