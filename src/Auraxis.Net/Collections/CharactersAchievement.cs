using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersAchievement
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("achievement_id")]
        public int AchievementId { get; private set; }

        [Json("earned_count")]
        public int EarnedCount { get; private set; }

        [Json("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset StartTime { get; private set; }

        [Json("finish")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset FinishTime { get; private set; }

        [Json("last_save")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastSaveTime { get; private set; }
    }
}
