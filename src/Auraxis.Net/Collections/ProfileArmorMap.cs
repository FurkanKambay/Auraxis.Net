using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ProfileArmorMap : ICountableCollection
    {
        [Json("profile_id")]
        public int ProfileId { get; private set; }

        [Json("armor_info_id")]
        public int ArmorInfoId { get; private set; }

        [Json("rank")]
        public int Rank { get; private set; }
    }
}
