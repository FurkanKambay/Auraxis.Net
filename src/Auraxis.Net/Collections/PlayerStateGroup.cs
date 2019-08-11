using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class PlayerStateGroup
    {
        [Json("player_state_group_id")]
        public int Id { get; private set; }

        [Json("player_state")]
        public PlayerState PlayerState { get; private set; }

        [Json("min_cone_of_fire")]
        public double? MinConeOfFire { get; private set; }
    }
}
