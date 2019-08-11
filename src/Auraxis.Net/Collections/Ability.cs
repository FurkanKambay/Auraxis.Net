using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Ability : ParamsBaseS4, ICountableCollection
    {
        [Json("ability_id")]
        public int Id { get; private set; }

        [Json("ability_type_id")]
        public int TypeId { get; private set; }

        [Json("distance_max")]
        public int? DistanceMax { get; private set; }

        [Json("expire_msec")]
        public int? ExpireMsec { get; private set; }

        [Json("first_use_delay_msec")]
        public int? FirstUseDelayMsec { get; private set; }

        [Json("flag_toggle")]
        public bool? FlagToggle { get; private set; }

        [Json("next_use_delay_msec")]
        public int? NextUseDelayMsec { get; private set; }

        [Json("radius_max")]
        public int? RadiusMax { get; private set; }

        [Json("resource_cost_per_msec")]
        public double? ResourceCostPerMsec { get; private set; }

        [Json("resource_first_cost")]
        public double? ResourceFirstCost { get; private set; }

        [Json("resource_type_id")]
        public ResourceType ResourceType { get; private set; }

        [Json("reuse_delay_msec")]
        public int? ReuseDelayMsec { get; private set; }
    }
}
