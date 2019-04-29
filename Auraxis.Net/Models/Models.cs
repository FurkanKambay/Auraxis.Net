using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Auraxis.Net
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Name
    {
        public string First { get; set; }
        public string FirstLower { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public struct Times
    {
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset LastSaveDate { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public int LoginCount { get; set; }
        public int MinutesPlayed { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public struct Certs
    {
        public int EarnedPoints { get; set; }
        public int GiftedPoints { get; set; }
        public int SpentPoints { get; set; }
        public int AvailablePoints { get; set; }
        public float PercentToNext { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public struct BattleRank
    {
        public int PercentToNext { get; set; }
        public int Value { get; set; }
    }

    public struct DailyRibbon
    {
        public int Count { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
