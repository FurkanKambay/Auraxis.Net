using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FireGroupToFireMode : ICountableCollection
    {
        [Json("fire_group_id")]
        public int FireGroupId { get; private set; }

        [Json("fire_mode_id")]
        public int FireModeId { get; private set; }

        [Json("fire_mode_index")]
        public int FireModeIndex { get; private set; }
    }
}
