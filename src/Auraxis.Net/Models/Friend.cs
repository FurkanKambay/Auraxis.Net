using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Friend
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("last_login_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastLoginTime { get; private set; }

        [Json("online")]
        public bool IsOnline { get; private set; }
    }
}
