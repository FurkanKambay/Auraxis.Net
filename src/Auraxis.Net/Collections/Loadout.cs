using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Loadout
    {
        [Json("loadout_id")]
        public int Id { get; private set; }

        [Json("profile_id")]
        public int ProfileId { get; private set; }

        [Json("faction_id")]
        public Empire Faction { get; private set; }

        [Json("code_name")]
        public string CodeName { get; private set; }
    }
}
