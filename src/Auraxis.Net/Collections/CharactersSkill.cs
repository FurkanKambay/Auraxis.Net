using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersSkill : ICountableCollection
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("skill_id")]
        public int SkillId { get; private set; }

        [Json("last_save")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastSaveTime { get; private set; }
    }
}
