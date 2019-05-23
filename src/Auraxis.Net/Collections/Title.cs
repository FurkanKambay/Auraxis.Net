using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Title
    {
        [Json("title_id")]
        public int TitleId { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }
    }
}
