using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharacterName : ICountableCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("name")]
        public Name Name { get; private set; }
    }
}
