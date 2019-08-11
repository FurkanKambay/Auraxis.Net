using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class SkillCategory : SkillBase
    {
        [Json("skill_category_id")]
        public int Id { get; private set; }

        [Json("skill_set_id")]
        public int SkillSetId { get; private set; }

        [Json("skill_set_index")]
        public int SkillSetIndex { get; private set; }

        [Json("skill_points")]
        public int SkillPoints { get; private set; }
    }
}
