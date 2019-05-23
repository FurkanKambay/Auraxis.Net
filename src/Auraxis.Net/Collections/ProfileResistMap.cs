using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ProfileResistMap
    {
        [Json("profile_id")]
        public int ProfileId { get; private set; }

        [Json("resist_info_id")]
        public int ResistInfoId { get; private set; }

        [Json("rank")]
        public int Rank { get; private set; }
    }
}
