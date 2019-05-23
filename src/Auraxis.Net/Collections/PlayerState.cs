using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class PlayerState
    {
        [Json("player_state_id")]
        public int PlayerStateId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
