using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class OutfitMember
    {
        [Json("outfit_id")]
        public long OutfitId { get; private set; }

        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("member_since")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset MemberSinceTime { get; private set; }

        [Json("rank")]
        public string Rank { get; private set; }

        [Json("rank_ordinal")]
        public int RankOrdinal { get; private set; }
    }
}
