using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ObjectiveType : ParamsBaseP9
    {
        [Json("objective_type_id")]
        public int Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
