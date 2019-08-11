using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class SkillSet : SkillBase, ICountableCollection
    {
        [Json("skill_set_id")]
        public int Id { get; private set; }

        [Json("skill_points")]
        public int? SkillPoints { get; private set; }

        [Json("required_item_id")]
        public int? RequiredItemId { get; private set; }
    }
}
