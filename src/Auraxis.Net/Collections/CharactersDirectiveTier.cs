using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersDirectiveTier
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("directive_tree_id")]
        public int DirectiveTreeId { get; private set; }

        [Json("directive_tier_id")]
        public int DirectiveTierId { get; private set; }

        [Json("completion_time_date")]
        public DateTimeOffset CompletionTimeDate { get; private set; }
    }
}
