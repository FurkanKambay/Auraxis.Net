using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net.EventStuff
{
    public class ContinentUnlock : ContinentLock { }
    public class ContinentLock
    {
        [Json("event_type")]
        public string EventType { get; set; }

        [Json("metagame_event_id")]
        public string MetagameEventId { get; set; }

        [Json("previous_faction")]
        public Empire PreviousFaction { get; set; }

        [Json("triggering_faction")]
        public Empire TriggeringFaction { get; set; }

        [Json("timestamp")]
        public string Timestamp { get; set; }

        [Json("nc_population")]
        public int NcPopulation { get; set; }

        [Json("tr_population")]
        public int TrPopulation { get; set; }

        [Json("vs_population")]
        public int VsPopulation { get; set; }

        [Json("world_id")]
        public Server World { get; set; }

        [Json("zone_id")]
        public Continent Zone { get; set; }
    }
}
