using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Skill : SkillBase
    {
        [Json("skill_id")]
        public int Id { get; private set; }

        [Json("skill_line_id")]
        public int LineId { get; private set; }

        [Json("skill_line_index")]
        public int LineIndex { get; private set; }

        [Json("skill_points")]
        public int Points { get; private set; }

        [Json("grant_item_id")]
        public int GrantItemId { get; private set; }
    }
}
