using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class EffectType
    {
        [Json("effect_type_id")]
        public int EffectTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
