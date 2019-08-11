using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class MetagameEvent
    {
        [Json("metagame_event_id")]
        public int Id { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("type")]
        public int Type { get; private set; }

        [Json("experience_bonus")]
        public int? ExperienceBonus { get; private set; }
    }
}
