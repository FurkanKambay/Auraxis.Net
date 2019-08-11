using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Profile2
    {
        [Json("profile_id")]
        public int Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
