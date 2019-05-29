using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public struct Times
    {
        [Json("creation_date")]
        public DateTimeOffset CreationDate { get; private set; }

        [Json("last_save_date")]
        public DateTimeOffset LastSaveDate { get; private set; }

        [Json("last_login_date")]
        public DateTimeOffset LastLoginDate { get; private set; }

        [Json("login_count")]
        public int LoginCount { get; private set; }

        [Json("minutes_played")]
        public int MinutesPlayed { get; private set; }
    }
}
