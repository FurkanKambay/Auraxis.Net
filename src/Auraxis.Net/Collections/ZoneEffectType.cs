using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ZoneEffectType : ParamsBaseS4
    {
        [Json("zone_effect_type_id")]
        public int Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
