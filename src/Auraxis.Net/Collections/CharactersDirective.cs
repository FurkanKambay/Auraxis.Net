using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersDirective : ICountableCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("directive_tree_id")]
        public int DirectiveTreeId { get; private set; }

        [Json("directive_id")]
        public int DirectiveId { get; private set; }

        [Json("completion_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset CompletionTime { get; private set; }
    }
}
