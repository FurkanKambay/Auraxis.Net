using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Image
    {
        [Json("image_id")]
        public int ImageId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("path")]
        public Uri Path { get; private set; }
    }
}
