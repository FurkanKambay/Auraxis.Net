using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // Exceptions
    // Can only be queried by 'character_id = x,y,z...' or equivalently 'id = x,y,z...'.
    // None of the 'c:' commands are supported (except c:join, c:tree).
    // Only 'get' is supported, 'count' is not.
    public class CharactersOnlineStatus
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("online_status")]
        public bool OnlineStatus { get; private set; }
    }
}
