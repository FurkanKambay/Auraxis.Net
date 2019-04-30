using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Auraxis.Net
{
    public class Character
    {
        [JsonProperty("character_id")]
        public long CharacterId { get; private set; }

        [JsonProperty("name")]
        public Name Name { get; private set; }

        [JsonProperty("faction_id")]
        public Empire Faction { get; private set; }

        [JsonProperty("head_id")]
        public int HeadId { get; private set; }

        [JsonProperty("title_id")]
        public int TitleId { get; private set; }

        [JsonProperty("times")]
        public Times Times { get; private set; }

        [JsonProperty("certs")]
        public Certs Certs { get; private set; }

        [JsonProperty("battle_rank")]
        public BattleRank BattleRank { get; private set; }

        [JsonProperty("profile_id")]
        public int ProfileId { get; private set; }

        [JsonProperty("daily_ribbon")]
        public DailyRibbon DailyRibbon { get; private set; }

        [JsonProperty("prestige_level")]
        public int PrestigeLevel { get; private set; }
    }
}
