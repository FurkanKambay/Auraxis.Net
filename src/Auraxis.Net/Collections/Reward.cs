using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Reward : ParamsBaseP5
    {
        [Json("reward_id")]
        public int Id { get; private set; }

        [Json("reward_type_id")]
        public int TypeId { get; private set; }

        [Json("count_min")]
        public int MinCount { get; private set; }

        [Json("count_max")]
        public int MaxCount { get; private set; }
    }
}
