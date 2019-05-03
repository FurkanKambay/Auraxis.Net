using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Auraxis.Net
{
    public class Name
    {
        [JsonProperty("first")]
        public string First { get; private set; }

        [JsonProperty("first_lower")]
        public string FirstLower { get; private set; }
    }

    public struct Times
    {
        [JsonProperty("creation_date")]
        public DateTimeOffset CreationDate { get; private set; }

        [JsonProperty("last_save_date")]
        public DateTimeOffset LastSaveDate { get; private set; }

        [JsonProperty("last_login_date")]
        public DateTimeOffset LastLoginDate { get; private set; }

        [JsonProperty("login_count")]
        public int LoginCount { get; private set; }

        [JsonProperty("minutes_played")]
        public int MinutesPlayed { get; private set; }
    }

    public struct Certs
    {
        [JsonProperty("earned_points")]
        public int EarnedPoints { get; private set; }

        [JsonProperty("gifted_points")]
        public int GiftedPoints { get; private set; }

        [JsonProperty("spent_points")]
        public int SpentPoints { get; private set; }

        [JsonProperty("available_points")]
        public int AvailablePoints { get; private set; }

        [JsonProperty("percent_to_next")]
        public float PercentToNext { get; private set; }
    }

    public struct BattleRank
    {
        [JsonProperty("percent_to_next")]
        public int PercentToNext { get; private set; }

        [JsonProperty("value")]
        public int Value { get; private set; }
    }

    public struct DailyRibbon
    {
        [JsonProperty("count")]
        public int Count { get; private set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; private set; }
    }
}
