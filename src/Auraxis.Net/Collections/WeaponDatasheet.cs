using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class WeaponDatasheet
    {
        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("direct_damage")]
        public int? DirectDamage { get; private set; }

        [Json("indirect_damage")]
        public int? IndirectDamage { get; private set; }

        [Json("damage")]
        public int? Damage { get; private set; }

        [Json("damage_min")]
        public int DamageMin { get; private set; }

        [Json("damage_max")]
        public int DamageMax { get; private set; }

        [Json("fire_cone")]
        public double? FireCone { get; private set; }

        [Json("fire_cone_min")]
        public double? FireConeMin { get; private set; }

        [Json("fire_cone_max")]
        public double? FireConeMax { get; private set; }

        [Json("fire_rate_ms")]
        public int? FireRateMs { get; private set; }

        [Json("fire_rate_ms_min")]
        public int? FireRateMsMin { get; private set; }

        [Json("fire_rate_mx_max")]
        public int? FireRateMsMax { get; private set; }

        [Json("reload_ms")]
        public int ReloadMs { get; private set; }

        [Json("reload_ms_min")]
        public int? ReloadMsMin { get; private set; }

        [Json("reload_ms_max")]
        public int? ReloadMsMax { get; private set; }

        [Json("clip_size")]
        public int? ClipSize { get; private set; }

        [Json("capacity")]
        public int? Capacity { get; private set; }

        [Json("range")]
        public LocalizedString Range { get; private set; }

        [Json("show_clip_size")]
        public bool? ShowClipSize { get; private set; }

        [Json("show_fire_modes")]
        public bool? ShowFireModes { get; private set; }

        [Json("show_range")]
        public bool? ShowRange { get; private set; }
    }
}
