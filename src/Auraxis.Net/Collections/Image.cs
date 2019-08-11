using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Image : ICountableCollection
    {
        [Json("image_id")]
        public int Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("path")]
        public Uri Path { get; private set; }
    }
}
