using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersDirective
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("directive_tree_id")]
        public int DirectiveTreeId { get; private set; }

        [Json("directive_id")]
        public int DirectiveId { get; private set; }

        [Json("completion_time_date")]
        public DateTimeOffset CompletionTimeDate { get; private set; }
    }
}
