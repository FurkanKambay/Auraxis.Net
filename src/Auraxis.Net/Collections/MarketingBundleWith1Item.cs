using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MarketingBundleWith1Item
    {
        [Json("marketing_bundle_id")]
        public int MarketingBundleId { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("item_quantity")]
        public int ItemQuantity { get; private set; }

        [Json("station_cash_price")]
        public int StationCashPrice { get; private set; }

        [Json("cert_price")]
        public int? CertPrice { get; private set; }

        [Json("release_time")]
        public int ReleaseTime { get; private set; }
    }
}
