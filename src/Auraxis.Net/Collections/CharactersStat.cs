using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersStat
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("stat_name")]
        public string StatName { get; private set; }

        [Json("profile_id")]
        public int ProfileId { get; private set; }

        [Json("value_forever")]
        public int ValueForever { get; private set; }

        [Json("value_monthly")]
        public int ValueMonthly { get; private set; }

        [Json("value_weekly")]
        public int ValueWeekly { get; private set; }

        [Json("value_daily")]
        public int ValueDaily { get; private set; }

        [Json("value_one_life_max")]
        public int ValueOneLifeMax { get; private set; }

        [Json("last_save")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastSaveTime { get; private set; }
    }
}
