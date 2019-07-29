using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public struct BattleRank
    {
        [Json("percent_to_next")]
        public int PercentToNext { get; private set; }

        [Json("value")]
        public int Value { get; private set; }
    }
}
