using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Name
    {
        [Json("first")]
        public string First { get; private set; }

        [Json("first_lower")]
        public string FirstLower { get; private set; }
    }
}
