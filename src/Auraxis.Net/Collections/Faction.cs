using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Faction
    {
        [Json("faction_id")]
        public Empire Id { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("image_set_id")]
        public int? ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }

        [Json("code_tag")]
        public string CodeTag { get; private set; }

        [Json("user_selectable")]
        public bool IsUserSelectable { get; private set; }
    }
}
