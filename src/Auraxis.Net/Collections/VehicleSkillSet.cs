using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class VehicleSkillSet : ICountableCollection
    {
        [Json("vehicle_id")]
        public int VehicleId { get; private set; }

        [Json("skill_set_id")]
        public int SkillSetId { get; private set; }

        [Json("faction_id")]
        public Empire Faction { get; private set; }

        [Json("display_index")]
        public int DisplayIndex { get; private set; }
    }
}
