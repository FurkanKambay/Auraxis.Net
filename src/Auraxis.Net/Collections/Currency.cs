using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Currency
    {
        [Json("currency_id")]
        public int CurrencyId { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("icon_id")]
        public int IconId { get; private set; }

        [Json("inventory_cap")]
        public int InventoryCap { get; private set; }
    }
}
