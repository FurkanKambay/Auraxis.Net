using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class DirectiveTree
    {
        [Json("directive_tree_id")]
        public int Id { get; private set; }

        [Json("directive_tree_category_id")]
        public int CategoryId { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }
    }
}
