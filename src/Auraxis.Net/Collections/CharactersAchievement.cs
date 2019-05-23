using System;
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

        [Json("start_date")]
        public DateTimeOffset StartDate { get; private set; }

        [Json("finish_date")]
        public DateTimeOffset FinishDate { get; private set; }

        [Json("last_save_date")]
        public DateTimeOffset LastSaveDate { get; private set; }
    }
}
