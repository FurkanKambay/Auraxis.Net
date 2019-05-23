using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MetagameEventState
    {
        [Json("metagame_event_state_id")]
        public int MetagameEventStateId { get; private set; }

        [Json("name")]
        public string Name { get; private set; }
    }
}
