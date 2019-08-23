using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // Exceptions
    // Can only be queried by 'character_id = x,y,z...' or equivalently 'id = x,y,z...'.
    // None of the 'c:' commands are supported (except c:join, c:tree).
    public class CharactersWorld : IRegularCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("world_id")]
        public Server World { get; private set; }
    }
}
