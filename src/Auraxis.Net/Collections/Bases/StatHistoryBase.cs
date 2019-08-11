using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public abstract class StatHistoryBase
    {
        [Json("stat_name")]
        public string StatName { get; private set; }

        [Json("all_time")]
        public int AllTime { get; private set; }

        [Json("last_save")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastSaveTime { get; private set; }

        [Json("day")]
        public Days DayValues { get; private set; }

        [Json("month")]
        public Months MonthValues { get; private set; }

        [Json("week")]
        public Weeks WeekValues { get; private set; }
    }
}
