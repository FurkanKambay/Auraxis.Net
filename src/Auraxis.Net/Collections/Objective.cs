using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Objective
    {
        [Json("objective_id")]
        public int ObjectiveId { get; private set; }

        [Json("objective_type_id")]
        public int ObjectiveTypeId { get; private set; }

        [Json("objective_group_id")]
        public int ObjectiveGroupId { get; private set; }
    }
}
