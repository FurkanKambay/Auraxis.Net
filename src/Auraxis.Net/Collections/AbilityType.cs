using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class AbilityType : ParamsBaseS4
    {
        [Json("ability_type_id")]
        public int Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
