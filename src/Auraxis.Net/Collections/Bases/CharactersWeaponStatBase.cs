using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public abstract class CharactersWeaponStatBase
    {
        [Json("character_id")]
        public long CharacterId { get; private set; }

        [Json("stat_name")]
        public string StatName { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("vehicle_id")]
        public int VehicleId { get; private set; }

        [Json("last_save")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastSaveTime { get; private set; }
    }
}
