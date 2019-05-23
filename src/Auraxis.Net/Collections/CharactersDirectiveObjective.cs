using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersDirectiveObjective
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("directive_id")]
        public int DirectiveId { get; private set; }

        [Json("objective_id")]
        public int ObjectiveId { get; private set; }

        [Json("objective_group_id")]
        public int ObjectiveGroupId { get; private set; }

        [Json("status")]
        public int Status { get; private set; }

        [Json("state_data")]
        public int StateData { get; private set; }
    }
}
