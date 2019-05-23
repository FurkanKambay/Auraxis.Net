using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class LocalizedString
    {
        [Json("de")]
        public string German { get; private set; }

        [Json("en")]
        public string English { get; private set; }

        [Json("es")]
        public string Spanish { get; private set; }

        [Json("fr")]
        public string French { get; private set; }

        [Json("it")]
        public string Italian { get; private set; }

        [Json("tr")]
        public string Turkish { get; private set; }
    }
}
