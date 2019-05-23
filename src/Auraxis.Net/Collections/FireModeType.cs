using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FireModeType
    {
        [Json("fire_mode_type_id")]
        public int FireModeTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
