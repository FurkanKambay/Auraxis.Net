using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class VehicleFaction
    {
        [Json("vehicle_id")]
        public int VehicleId { get; private set; }

        [Json("faction_id")]
        public Empire Faction { get; private set; }
    }
}
