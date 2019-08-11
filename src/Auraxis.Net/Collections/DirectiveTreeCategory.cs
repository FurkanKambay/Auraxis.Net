using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class DirectiveTreeCategory : ICountableCollection
    {
        [Json("directive_tree_category_id")]
        public int Id { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }
    }
}
