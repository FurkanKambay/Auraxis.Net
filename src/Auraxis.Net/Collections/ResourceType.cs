using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ResourceType
    {
        [Json("resource_type_id")]
        public int ResourceTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
