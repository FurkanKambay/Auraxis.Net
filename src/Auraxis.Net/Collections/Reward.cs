using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Reward
    {
        [Json("reward_id")]
        public int RewardId { get; private set; }

        [Json("reward_type_id")]
        public int RewardTypeId { get; private set; }

        [Json("count_min")]
        public int CountMin { get; private set; }

        [Json("count_max")]
        public int CountMax { get; private set; }
    }
}
