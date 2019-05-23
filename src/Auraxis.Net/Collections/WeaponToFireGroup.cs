using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class WeaponToFireGroup
    {
        [Json("weapon_id")]
        public int WeaponId { get; private set; }

        [Json("fire_group_id")]
        public int FireGroupId { get; private set; }

        [Json("fire_group_index")]
        public int FireGroupIndex { get; private set; }
    }
}
