using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class RewardType
    {
        [Json("reward_type_id")]
        public int RewardTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("count_min")]
        public string CountMin { get; private set; }

        [Json("count_max")]
        public string CountMax { get; private set; }
    }
}
