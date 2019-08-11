using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ItemCategory : ICountableCollection
    {
        [Json("item_category_id")]
        public int Id { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }
    }
}
