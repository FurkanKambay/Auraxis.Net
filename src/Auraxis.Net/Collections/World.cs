using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // Exceptions
    // Querying by name.en, name.fr, etc is not supported.
    public class World
    {
        [Json("world_id")]
        public int WorldId { get; private set; }

        [Json("state")]
        public string State { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }
    }
}
