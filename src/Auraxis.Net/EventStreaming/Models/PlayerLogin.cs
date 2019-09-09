using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net.EventStuff
{
    public class PlayerLogout : PlayerLogin { }
    public class PlayerLogin
    {
        [Json("character_id")]
        public long CharacterId { get; set; }

        [Json("timestamp")]
        public string Timestamp { get; set; }

        [Json("world_id")]
        public Server World { get; set; }
    }
}
