using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class VehicleAttachment
    {
        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("vehicle_id")]
        public int VehicleId { get; private set; }

        [Json("faction_id")]
        public Empire Faction { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("slot_id")]
        public int SlotId { get; private set; }
    }
}
