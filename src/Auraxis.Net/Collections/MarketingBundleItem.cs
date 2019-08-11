using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MarketingBundleItem : ICountableCollection
    {
        [Json("marketing_bundle_id")]
        public int MarketingBundleId { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("quantity")]
        public int Quantity { get; private set; }

        [Json("release_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset ReleaseTime { get; private set; }
    }
}
