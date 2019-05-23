using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class OutfitMemberExtended : Outfit
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("member_since_date")]
        public DateTimeOffset MemberSinceDate { get; private set; }

        [Json("member_rank")]
        public string MemberRank { get; private set; }

        [Json("member_rank_ordinal")]
        public int MemberRankOrdinal { get; private set; }
    }
}
