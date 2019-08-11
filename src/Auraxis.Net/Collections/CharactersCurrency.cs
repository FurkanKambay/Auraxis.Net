using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersCurrency : ICountableCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("currency_id")]
        public int CurrencyId { get; private set; }

        [Json("currency_name")]
        public string CurrencyName { get; private set; }

        [Json("quantity")]
        public int Quantity { get; private set; }

        [Json("prestige_currency")]
        public int PrestigeCurrency { get; private set; }
    }
}
