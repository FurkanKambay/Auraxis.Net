using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class OutfitMemberExtended : Outfit, ICountableCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("member_since")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset MemberSinceTime { get; private set; }

        [Json("member_rank")]
        public string MemberRank { get; private set; }

        [Json("member_rank_ordinal")]
        public int MemberRankOrdinal { get; private set; }
    }
}
