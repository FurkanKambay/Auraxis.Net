using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MarketingBundleItem
    {
        [Json("marketing_bundle_id")]
        public int MarketingBundleId { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("quantity")]
        public int Quantity { get; private set; }

        [Json("release_time")]
        public int ReleaseTime { get; private set; }
    }
}
