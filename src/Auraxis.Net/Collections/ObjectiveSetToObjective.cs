using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ObjectiveSetToObjective
    {
        [Json("objective_set_id")]
        public int ObjectiveSetId { get; private set; }

        [Json("objective_group_id")]
        public int ObjectiveGroupId { get; private set; }
    }
}
