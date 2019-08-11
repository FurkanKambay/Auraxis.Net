using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ItemToWeapon : ICountableCollection
    {
        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("weapon_id")]
        public int WeaponId { get; private set; }
    }
}
