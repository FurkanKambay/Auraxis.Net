using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ZoneEffect
    {
        [Json("zone_effect_id")]
        public int ZoneEffectId { get; private set; }

        [Json("zone_effect_type_id")]
        public int ZoneEffectTypeId { get; private set; }

        [Json("ability_id")]
        public int AbilityId { get; private set; }
    }
}
