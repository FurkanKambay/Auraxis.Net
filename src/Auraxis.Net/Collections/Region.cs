using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Region
    {
        [Json("region_id")]
        public int RegionId { get; private set; }

        [Json("zone_id")]
        public int ZoneId { get; private set; }

        [Json("initial_faction_id")]
        public Empire InitialFaction { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }
    }
}
