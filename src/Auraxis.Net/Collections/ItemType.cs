using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ItemType : ICountableCollection
    {
        [Json("item_type_id")]
        public int Id { get; private set; }

        [Json("name")]
        public string Name { get; private set; }

        [Json("code")]
        public string Code { get; private set; }
    }
}
