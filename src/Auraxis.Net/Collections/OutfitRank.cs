using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class OutfitRank : ICountableCollection
    {
        [Json("outfit_id")]
        public long OutfitId { get; private set; }

        [Json("ordinal")]
        public int Ordinal { get; private set; }

        [Json("name")]
        public string Name { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
