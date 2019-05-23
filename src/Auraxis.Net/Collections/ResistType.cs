using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ResistType
    {
        [Json("resist_type_id")]
        public int ResistTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
