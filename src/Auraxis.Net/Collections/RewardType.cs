using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class RewardType : ParamsBaseP5
    {
        [Json("reward_type_id")]
        public int Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("count_min")]
        public string MinCount { get; private set; }

        [Json("count_max")]
        public string MaxCount { get; private set; }
    }
}
