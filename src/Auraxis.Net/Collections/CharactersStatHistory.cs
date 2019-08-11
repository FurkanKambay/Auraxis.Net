using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersStatHistory : StatHistoryBase, ICountableCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("one_life_max")]
        public int OneLifeMax { get; private set; }
    }
}
