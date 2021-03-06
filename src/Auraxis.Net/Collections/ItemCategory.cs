using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ItemCategory
    {
        [Json("item_category_id")]
        public int ItemCategoryId { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }
    }
}
