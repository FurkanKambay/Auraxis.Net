using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class RewardSetToRewardGroup : ICountableCollection
    {
        [Json("reward_set_id")]
        public int RewardSetId { get; private set; }

        [Json("reward_group_id")]
        public int RewardGroupId { get; private set; }
    }
}
