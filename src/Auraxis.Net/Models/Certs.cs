using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public struct Certs
    {
        [Json("earned_points")]
        public int EarnedPoints { get; private set; }

        [Json("gifted_points")]
        public int GiftedPoints { get; private set; }

        [Json("spent_points")]
        public int SpentPoints { get; private set; }

        [Json("available_points")]
        public int AvailablePoints { get; private set; }

        [Json("percent_to_next")]
        public double PercentToNext { get; private set; }
    }
}
