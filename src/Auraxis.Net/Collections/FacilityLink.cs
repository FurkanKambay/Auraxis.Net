using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FacilityLink
    {
        [Json("zone_id")]
        public int ZoneId { get; private set; }

        [Json("facility_id_a")]
        public int FacilityIdA { get; private set; }

        [Json("facility_id_b")]
        public int FacilityIdB { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
