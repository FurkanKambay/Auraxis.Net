using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Character : CharacterName, ICountableCollection
    {
        [Json("faction_id")]
        public Empire Faction { get; private set; }

        [Json("head_id")]
        public int HeadId { get; private set; }

        [Json("title_id")]
        public int TitleId { get; private set; }

        [Json("times")]
        public Times Times { get; private set; }

        [Json("certs")]
        public Certs Certs { get; private set; }

        [Json("battle_rank")]
        public BattleRank BattleRank { get; private set; }

        [Json("profile_id")]
        public int ProfileId { get; private set; }

        [Json("daily_ribbon")]
        public DailyRibbon DailyRibbon { get; private set; }

        [Json("prestige_level")]
        public int PrestigeLevel { get; private set; }
    }
}
