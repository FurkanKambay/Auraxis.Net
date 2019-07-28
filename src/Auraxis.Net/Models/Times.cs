using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public struct Times
    {
        [Json("creation")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset CreationTime { get; private set; }

        [Json("last_save")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastSaveTime { get; private set; }

        [Json("last_login")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastLoginTime { get; private set; }

        [Json("login_count")]
        public int LoginCount { get; private set; }

        [Json("minutes_played")]
        public int MinutesPlayed { get; private set; }
    }
}
