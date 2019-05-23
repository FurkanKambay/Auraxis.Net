using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MapHex
    {
        [Json("zone_id")]
        public int ZoneId { get; private set; }

        [Json("map_region_id")]
        public int MapRegionId { get; private set; }

        [Json("x")]
        public int X { get; private set; }

        [Json("y")]
        public int Y { get; private set; }

        [Json("hex_type")]
        public int HexType { get; private set; }

        [Json("type_name")]
        public string TypeName { get; private set; }
    }
}
