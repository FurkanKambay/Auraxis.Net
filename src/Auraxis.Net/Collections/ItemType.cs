using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ItemType
    {
        [Json("item_type_id")]
        public int ItemTypeId { get; private set; }

        [Json("name")]
        public string Name { get; private set; }

        [Json("code")]
        public string Code { get; private set; }
    }
}
