using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersDirectiveTree
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("directive_tree_id")]
        public int DirectiveTreeId { get; private set; }

        [Json("current_directive_tier_id")]
        public int CurrentDirectiveTierId { get; private set; }

        [Json("current_level")]
        public int CurrentLevel { get; private set; }

        [Json("completion_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset CompletionTime { get; private set; }
    }
}
