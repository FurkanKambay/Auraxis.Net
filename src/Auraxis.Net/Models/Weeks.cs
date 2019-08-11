using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Weeks
    {
        [Json("w01")] public int Week1 { get; private set; }
        [Json("w02")] public int Week2 { get; private set; }
        [Json("w03")] public int Week3 { get; private set; }
        [Json("w04")] public int Week4 { get; private set; }
        [Json("w05")] public int Week5 { get; private set; }
        [Json("w06")] public int Week6 { get; private set; }
        [Json("w07")] public int Week7 { get; private set; }
        [Json("w08")] public int Week8 { get; private set; }
        [Json("w09")] public int Week9 { get; private set; }
        [Json("w10")] public int Week10 { get; private set; }
        [Json("w11")] public int Week11 { get; private set; }
        [Json("w12")] public int Week12 { get; private set; }
        [Json("w13")] public int Week13 { get; private set; }
    }
}
