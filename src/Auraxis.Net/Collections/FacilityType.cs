using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FacilityType
    {
        [Json("facility_type_id")]
        public int FacilityTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
