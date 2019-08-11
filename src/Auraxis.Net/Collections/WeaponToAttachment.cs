using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class WeaponToAttachment : ICountableCollection
    {
        [Json("weapon_group_id")]
        public int WeaponGroupId { get; private set; }

        [Json("attachment_id")]
        public int AttachmentId { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }
    }
}
