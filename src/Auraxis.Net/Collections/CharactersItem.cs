using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // Exceptions
    // Can only be queried by 'character_id = x,y,z...' or equivalently 'id = x,y,z...'.
    // None of the 'c:' commands are supported (except c:join, c:tree).
    public class CharactersItem : ICountableCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("stack_count")]
        public int StackCount { get; private set; } = 1;
    }
}
