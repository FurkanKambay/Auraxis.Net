using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Rank
    {
        [Json("title")]
        public LocalizedString Title { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_id")]
        public int ImageId { get; private set; }
    }
}
