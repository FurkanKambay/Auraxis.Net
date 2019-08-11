using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class EmpireScores : ICountableCollection
    {
        [Json("tracker_name")]
        public string TrackerName { get; private set; }

        [Json("tracker_description")]
        public string TrackerDescription { get; private set; }

        [Json("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset StartTime { get; private set; }

        [Json("end_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset EndTime { get; private set; }

        [Json("name")]
        public Name Name { get; private set; }
    }
}
