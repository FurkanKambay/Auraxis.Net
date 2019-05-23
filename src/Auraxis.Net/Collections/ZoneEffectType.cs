using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ZoneEffectType
    {
        [Json("zone_effect_type_id")]
        public int ZoneEffectTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
