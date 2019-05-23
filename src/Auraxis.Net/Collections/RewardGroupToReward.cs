using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class RewardGroupToReward
    {
        [Json("reward_group_id")]
        public int RewardGroupId { get; private set; }

        [Json("reward_id")]
        public int RewardId { get; private set; }
    }
}
