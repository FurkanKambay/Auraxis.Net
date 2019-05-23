using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersSkill
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("skill_id")]
        public int SkillId { get; private set; }

        [Json("last_save_date")]
        public DateTimeOffset LastSaveDate { get; private set; }
    }
}
