using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Skill : SkillBase
    {
        [Json("skill_id")]
        public int SkillId { get; private set; }

        [Json("skill_line_id")]
        public int SkillLineId { get; private set; }

        [Json("skill_line_index")]
        public int SkillLineIndex { get; private set; }

        [Json("skill_points")]
        public int SkillPoints { get; private set; }

        [Json("grant_item_id")]
        public int GrantItemId { get; private set; }
    }
}
