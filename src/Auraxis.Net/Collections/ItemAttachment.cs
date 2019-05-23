using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ItemAttachment
    {
        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("attachment_item_id")]
        public int AttachmentItemId { get; private set; }
    }
}
