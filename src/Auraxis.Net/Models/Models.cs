using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Name
    {
        [Json("first")]
        public string First { get; private set; }

        [Json("first_lower")]
        public string FirstLower { get; private set; }
    }

    public struct Times
    {
        [Json("creation_date")]
        public DateTimeOffset CreationDate { get; private set; }

        [Json("last_save_date")]
        public DateTimeOffset LastSaveDate { get; private set; }

        [Json("last_login_date")]
        public DateTimeOffset LastLoginDate { get; private set; }

        [Json("login_count")]
        public int LoginCount { get; private set; }

        [Json("minutes_played")]
        public int MinutesPlayed { get; private set; }
    }

    public struct Certs
    {
        [Json("earned_points")]
        public int EarnedPoints { get; private set; }

        [Json("gifted_points")]
        public int GiftedPoints { get; private set; }

        [Json("spent_points")]
        public int SpentPoints { get; private set; }

        [Json("available_points")]
        public int AvailablePoints { get; private set; }

        [Json("percent_to_next")]
        public double PercentToNext { get; private set; }
    }

    public struct BattleRank
    {
        [Json("percent_to_next")]
        public int PercentToNext { get; private set; }

        [Json("value")]
        public int Value { get; private set; }
    }

    public struct DailyRibbon
    {
        [Json("count")]
        public int Count { get; private set; }

        [Json("date")]
        public DateTimeOffset? Date { get; private set; }
    }
}
