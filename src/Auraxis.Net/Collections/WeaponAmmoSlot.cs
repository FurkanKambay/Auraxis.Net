using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class WeaponAmmoSlot
    {
        [Json("weapon_id")]
        public int WeaponId { get; private set; }

        [Json("weapon_slot_index")]
        public int WeaponSlotIndex { get; private set; }

        [Json("clip_size")]
        public int ClipSize { get; private set; }

        [Json("capacity")]
        public int Capacity { get; private set; }

        [Json("refill_ammo_rate")]
        public int? RefillAmmoRate { get; private set; }

        [Json("refill_ammo_delay_ms")]
        public int? RefillAmmoDelayMs { get; private set; }
    }
}
