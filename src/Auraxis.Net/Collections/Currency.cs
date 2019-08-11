using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Currency : ICountableCollection
    {
        [Json("currency_id")]
        public int Id { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("icon_id")]
        public int IconId { get; private set; }

        [Json("inventory_cap")]
        public int InventoryCap { get; private set; }
    }
}
