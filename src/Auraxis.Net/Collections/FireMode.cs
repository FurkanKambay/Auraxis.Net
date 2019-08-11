using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FireMode : ICountableCollection
    {
        [Json("fire_mode_id")]
        public int Id { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("type")]
        public string Type { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("player_state_group_id")]
        public int? PlayerStateGroupId { get; private set; }

        [Json("cof_recoil")]
        public double? ConeOfFireRecoil { get; private set; }

        [Json("reload_time_ms")]
        public int? ReloadTimeMs { get; private set; }

        [Json("reload_chamber_time_ms")]
        public int? ReloadChamberTimeMs { get; private set; }

        [Json("pellets_per_shot")]
        public int? PelletsPerShot { get; private set; }

        [Json("pellet_spread")]
        public double? PelletSpread { get; private set; }

        [Json("default_zoom")]
        public double DefaultZoom { get; private set; }

        [Json("muzzle_velocity")]
        public int? MuzzleVelocity { get; private set; }

        [Json("speed")]
        public int Speed { get; private set; }

        [Json("max_speed")]
        public int? MaxSpeed { get; private set; }

        [Json("damage_radius")]
        public int? DamageRadius { get; private set; }

        [Json("projectile_description")]
        public string ProjectileDescription { get; private set; }

        [Json("damage_type")]
        public int DamageType { get; private set; }

        [Json("damage")]
        public int? Damage { get; private set; }

        [Json("damage_min")]
        public int? DamageMin { get; private set; }

        [Json("damage_max")]
        public int? DamageMax { get; private set; }

        [Json("damage_min_range")]
        public int? DamageMinRange { get; private set; }

        [Json("damage_max_range")]
        public int? DamageMaxRange { get; private set; }

        [Json("damage_target_type")]
        public TargetType? DamageTargetType { get; private set; }

        [Json("damage_resist_type")]
        public int DamageResistType { get; private set; }

        [Json("indirect_damage_max")]
        public int? IndirectDamageMax { get; private set; }

        [Json("indirect_damage_max_range")]
        public double? IndirectDamageMaxRange { get; private set; }

        [Json("indirect_damage_min")]
        public int? IndirectDamageMin { get; private set; }

        [Json("indirect_damage_min_range")]
        public double? IndirectDamageMinRange { get; private set; }

        [Json("indirect_damage_target_type")]
        public TargetType? IndirectDamageTargetType { get; private set; }

        [Json("indirect_damage_resist_type")]
        public int? IndirectDamageResistType { get; private set; }
    }
}
