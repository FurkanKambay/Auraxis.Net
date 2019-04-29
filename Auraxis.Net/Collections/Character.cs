using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Auraxis.Net
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Character
    {
        public long CharacterId { get; set; }
        public Name Name { get; set; }
        public Empire FactionId { get; set; }
        public int HeadId { get; set; }
        public int TitleId { get; set; }
        public Times Times { get; set; }
        public Certs Certs { get; set; }
        public BattleRank BattleRank { get; set; }
        public int ProfileId { get; set; }
        public DailyRibbon DailyRibbon { get; set; }
        public int PrestigeLevel { get; set; }
    }
}
