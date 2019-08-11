using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // TODO: Find a better solution

    public abstract class ParamsBaseP5
    {
        [Json("param1")]
        public string Param1 { get; private set; }

        [Json("param2")]
        public string Param2 { get; private set; }

        [Json("param3")]
        public string Param3 { get; private set; }

        [Json("param4")]
        public string Param4 { get; private set; }

        [Json("param5")]
        public string Param5 { get; private set; }
    }

    public abstract class ParamsBaseP9 : ParamsBaseP5
    {
        [Json("param6")]
        public string Param6 { get; private set; }

        [Json("param7")]
        public string Param7 { get; private set; }

        [Json("param8")]
        public string Param8 { get; private set; }

        [Json("param9")]
        public string Param9 { get; private set; }
    }

    public abstract class ParamsBaseP13 : ParamsBaseP9
    {
        [Json("param10")]
        public string Param10 { get; private set; }

        [Json("param11")]
        public string Param11 { get; private set; }

        [Json("param12")]
        public string Param12 { get; private set; }

        [Json("param13")]
        public string Param13 { get; private set; }
    }

    public abstract class ParamsBaseS4 : ParamsBaseP13
    {
        [Json("param14")]
        public string Param14 { get; private set; }

        [Json("string1")]
        public string String1 { get; private set; }

        [Json("string2")]
        public string String2 { get; private set; }

        [Json("string3")]
        public string String3 { get; private set; }

        [Json("string4")]
        public string String4 { get; private set; }
    }
}
