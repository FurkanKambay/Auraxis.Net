using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Months
    {
        [Json("m01")] public int Month1 { get; private set; }
        [Json("m02")] public int Month2 { get; private set; }
        [Json("m03")] public int Month3 { get; private set; }
        [Json("m04")] public int Month4 { get; private set; }
        [Json("m05")] public int Month5 { get; private set; }
        [Json("m06")] public int Month6 { get; private set; }
        [Json("m07")] public int Month7 { get; private set; }
        [Json("m08")] public int Month8 { get; private set; }
        [Json("m09")] public int Month9 { get; private set; }
        [Json("m10")] public int Month10 { get; private set; }
        [Json("m11")] public int Month11 { get; private set; }
        [Json("m12")] public int Month12 { get; private set; }
    }
}
