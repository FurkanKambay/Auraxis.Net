using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ItemProfile
    {
        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("profile_id")]
        public int ProfileId { get; private set; }
    }
}
