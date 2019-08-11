using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FacilityLink : ICountableCollection
    {
        [Json("zone_id")]
        public Continent Zone { get; private set; }

        [Json("facility_id_a")]
        public int FacilityIdA { get; private set; }

        [Json("facility_id_b")]
        public int FacilityIdB { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
