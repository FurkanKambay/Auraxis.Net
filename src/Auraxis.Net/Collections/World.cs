using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // Exceptions
    // Querying by name.en, name.fr, etc is not supported.
    public class World : ICountableCollection
    {
        [Json("world_id")]
        public Server Id { get; private set; }

        [Json("state")]
        public WorldState State { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }
    }
}
