using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class CharactersWeaponStat : CharactersWeaponStatBase, ICountableCollection
    {
        [Json("value")]
        public int Value { get; private set; }
    }
}
