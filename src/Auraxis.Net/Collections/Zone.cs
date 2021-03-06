using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Zone
    {
        [Json("zone_id")]
        public int ZoneId { get; private set; }

        [Json("code")]
        public string Code { get; private set; }

        [Json("hex_size")]
        public int HexSize { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }
    }
}
