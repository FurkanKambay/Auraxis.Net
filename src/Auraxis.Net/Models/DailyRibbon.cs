using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public struct DailyRibbon
    {
        [Json("count")]
        public int Count { get; private set; }

        [Json("date")]
        public DateTimeOffset? Date { get; private set; }
    }
}
