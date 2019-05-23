using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ResistInfo
    {
        [Json("resist_info_id")]
        public int ResistInfoId { get; private set; }

        [Json("resist_type_id")]
        public int ResistTypeId { get; private set; }

        [Json("resist_percent")]
        public int ResistPercent { get; private set; }

        [Json("resist_amount")]
        public int? ResistAmount { get; private set; }

        [Json("multiplier_when_headshot")]
        public int MultiplierWhenHeadshot { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
