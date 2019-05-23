using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ObjectiveType
    {
        [Json("objective_type_id")]
        public int ObjectiveTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
