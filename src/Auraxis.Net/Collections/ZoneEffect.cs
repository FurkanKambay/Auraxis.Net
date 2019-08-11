using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ZoneEffect : ParamsBaseS4
    {
        [Json("zone_effect_id")]
        public int Id { get; private set; }

        [Json("zone_effect_type_id")]
        public int TypeId { get; private set; }

        [Json("ability_id")]
        public int AbilityId { get; private set; }
    }
}
