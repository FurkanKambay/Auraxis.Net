using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ArmorInfo : ICountableCollection
    {
        [Json("armor_info_id")]
        public int Id { get; private set; }

        [Json("armor_facing_id")]
        public ArmorFacing ArmorFacing { get; private set; }

        [Json("armor_percent")]
        public int ArmorPercent { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
