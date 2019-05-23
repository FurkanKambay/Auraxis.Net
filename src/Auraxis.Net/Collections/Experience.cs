using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Experience
    {
        [Json("experience_id")]
        public string ExperienceId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }

        [Json("xp")]
        public string Xp { get; private set; }
    }
}
