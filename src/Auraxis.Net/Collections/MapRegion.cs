using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MapRegion
    {
        [Json("map_region_id")]
        public int Id { get; private set; }

        [Json("zone_id")]
        public Continent Zone { get; private set; }

        [Json("facility_id")]
        public int FacilityId { get; private set; }

        [Json("facility_name")]
        public string FacilityName { get; private set; }

        [Json("facility_type_id")]
        public FacilityType FacilityType { get; private set; }

        [Json("facility_type")]
        public string FacilityTypeName { get; private set; }

        [Json("location_x")]
        public double LocationX { get; private set; }

        [Json("location_y")]
        public double LocationY { get; private set; }

        [Json("location_z")]
        public double LocationZ { get; private set; }

        [Json("reward_amount")]
        public int? RewardAmount { get; private set; }

        [Json("reward_currency_id")]
        public int? RewardCurrencyId { get; private set; }
    }
}
