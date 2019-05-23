using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersWeaponStatByFaction : CharactersWeaponStatBase
    {
        [Json("value_vs")]
        public int ValueVS { get; private set; }

        [Json("value_nc")]
        public int ValueNC { get; private set; }

        [Json("value_tr")]
        public int ValueTR { get; private set; }
    }
}
