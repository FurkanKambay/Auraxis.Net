using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class OutfitMember : ICountableCollection
    {
        [Json("outfit_id")]
        public long OutfitId { get; private set; }

        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("member_since")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset MemberSinceTime { get; private set; }

        [Json("rank")]
        public string RankName { get; private set; }

        [Json("rank_ordinal")]
        public OutfitMemberRank Rank { get; private set; }
    }
}
