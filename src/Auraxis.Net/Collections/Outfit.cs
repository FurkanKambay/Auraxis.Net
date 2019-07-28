using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Outfit
    {
        [Json("outfit_id")]
        public long OutfitId { get; private set; }

        [Json("name")]
        public string Name { get; private set; }

        [Json("name_lower")]
        public string NameLower { get; private set; }

        [Json("alias")]
        public string Alias { get; private set; }

        [Json("alias_lower")]
        public string AliasLower { get; private set; }

        [Json("time_created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset CreationTime { get; private set; }

        [Json("leader_character_id")]
        public long LeaderCharacterId { get; private set; }

        [Json("member_count")]
        public int MemberCount { get; private set; }
    }
}
