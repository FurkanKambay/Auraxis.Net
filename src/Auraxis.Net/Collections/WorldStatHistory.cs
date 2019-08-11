using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class WorldStatHistory : StatHistoryBase, ICountableCollection
    {
        [Json("world_id")]
        public Server World { get; private set; }

        [Json("type")]
        public string Type { get; private set; }

        [Json("tracker_name")]
        public string TrackerName { get; private set; }

        [Json("faction")]
        public Empire Faction { get; private set; }
    }
}
