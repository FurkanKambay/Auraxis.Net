using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ImageSetDefault : ImageSet { }

    public class ImageSet
    {
        [Json("image_set_id")]
        public int Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("type_id")]
        public int TypeId { get; private set; }

        [Json("type_description")]
        public string TypeDescription { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }
    }
}
