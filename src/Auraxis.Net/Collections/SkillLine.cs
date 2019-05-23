using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class SkillLine : SkillBase
    {
        [Json("skill_line_id")]
        public int SkillLineId { get; private set; }

        [Json("skill_points")]
        public int SkillPoints { get; private set; }

        [Json("skill_category_id")]
        public int? SkillCategoryId { get; private set; }

        [Json("skill_category_index")]
        public int? SkillCategoryIndex { get; private set; }
    }
}
