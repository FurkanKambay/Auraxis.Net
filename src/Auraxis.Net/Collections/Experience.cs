using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Experience : ICountableCollection
    {
        [Json("experience_id")]
        public string Id { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("xp")]
        public double Value { get; private set; }
    }
}
