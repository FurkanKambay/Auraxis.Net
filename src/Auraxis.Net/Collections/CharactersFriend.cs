using System.Collections.Generic;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // Exceptions
    // Can only be queried by 'character_id = x,y,z...' or equivalently 'id = x,y,z...'.
    // None of the 'c:' commands are supported (except c:join, c:tree).
    public class CharactersFriend : ICollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("name")]
        public string Name { get; private set; }

        [Json("friend_list")]
        public List<Friend> FriendList { get; private set; }
    }
}
