using System;
using Auraxis.Net.Helpers;
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
        [JsonArrayPath("d{0:00}")]
        [JsonConverter(typeof(HistoryArrayConverter))]
        public int[] DayValues { get; private set; }

        [Json("week")]
        [JsonArrayPath("w{0:00}")]
        [JsonConverter(typeof(HistoryArrayConverter))]
        public int[] WeekValues { get; private set; }

        [Json("month")]
        [JsonArrayPath("m{0:00}")]
        [JsonConverter(typeof(HistoryArrayConverter))]
        public int[] MonthValues { get; private set; }
    }
}
