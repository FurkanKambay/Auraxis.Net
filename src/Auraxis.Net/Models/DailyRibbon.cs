using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public struct DailyRibbon
    {
        [Json("count")]
        public int Count { get; private set; }

        [Json("time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset? Time { get; private set; }
    }
}
