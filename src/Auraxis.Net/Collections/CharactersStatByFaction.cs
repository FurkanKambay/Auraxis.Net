using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersStatByFaction
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("stat_name")]
        public string StatName { get; private set; }

        [Json("profile_id")]
        public int ProfileId { get; private set; }

        [Json("value_forever_vs")]
        public int ValueForeverVs { get; private set; }

        [Json("value_forever_nc")]
        public int ValueForeverNc { get; private set; }

        [Json("value_forever_tr")]
        public int ValueForeverTr { get; private set; }

        [Json("value_monthly_vs")]
        public int ValueMonthlyVs { get; private set; }

        [Json("value_monthly_nc")]
        public int ValueMonthlyNc { get; private set; }

        [Json("value_monthly_tr")]
        public int ValueMonthlyTr { get; private set; }

        [Json("value_weekly_vs")]
        public int ValueWeeklyVs { get; private set; }

        [Json("value_weekly_nc")]
        public int ValueWeeklyNc { get; private set; }

        [Json("value_weekly_tr")]
        public int ValueWeeklyTr { get; private set; }

        [Json("value_daily_vs")]
        public int ValueDailyVs { get; private set; }

        [Json("value_daily_nc")]
        public int ValueDailyNc { get; private set; }

        [Json("value_daily_tr")]
        public int ValueDailyTr { get; private set; }

        [Json("value_one_life_max_vs")]
        public int ValueOneLifeMaxVs { get; private set; }

        [Json("value_one_life_max_nc")]
        public int ValueOneLifeMaxNc { get; private set; }

        [Json("value_one_life_max_tr")]
        public int ValueOneLifeMaxTr { get; private set; }

        [Json("last_save_date")]
        public DateTimeOffset LastSaveDate { get; private set; }
    }
}
