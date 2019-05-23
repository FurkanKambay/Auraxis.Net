using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MarketingBundle
    {
        [Json("marketing_bundle_id")]
        public int MarketingBundleId { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("image_id")]
        public int ImageId { get; private set; }

        [Json("station_cash_price")]
        public int StationCashPrice { get; private set; }

        [Json("cert_price")]
        public int? CertPrice { get; private set; }

        [Json("release_time")]
        public int ReleaseTime { get; private set; }
    }
}
