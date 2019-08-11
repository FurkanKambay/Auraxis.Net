using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FireMode2 : ICountableCollection
    {
        [Json("fire_mode_id")]
        public int Id { get; private set; }

        [Json("fire_mode_type_id")]
        public int? TypeId { get; private set; }

        [Json("ability_id")]
        public int? AbilityId { get; private set; }

        [Json("ammo_slot")]
        public int? AmmoSlot { get; private set; }

        [Json("automatic")]
        public bool Automatic { get; private set; }

        [Json("grief_immune")]
        public bool? GriefImmune { get; private set; }

        [Json("iron_sights")]
        public bool? IronSights { get; private set; }

        [Json("laser_guided")]
        public bool? LaserGuided { get; private set; }

        [Json("move_modifier")]
        public double MoveModifier { get; private set; }

        [Json("projectile_speed_override")]
        public int? ProjectileSpeedOverride { get; private set; }

        [Json("sprint_fire")]
        public bool? SprintFire { get; private set; }

        [Json("turn_modifier")]
        public double TurnModifier { get; private set; }

        [Json("use_in_water")]
        public bool? UseInWater { get; private set; }

        [Json("zoom_default")]
        public double ZoomDefault { get; private set; }

        [Json("cof_override")]
        public int? CofOverride { get; private set; }

        [Json("cof_pellet_spread")]
        public double? CofPelletSpread { get; private set; }

        [Json("cof_range")]
        public double CofRange { get; private set; }

        [Json("cof_recoil")]
        public double? CofRecoil { get; private set; }

        [Json("cof_scalar")]
        public double CofScalar { get; private set; }

        [Json("cof_scalar_moving")]
        public int CofScalarMoving { get; private set; }

        [Json("player_state_group_id")]
        public int PlayerStateGroupId { get; private set; }

        [Json("damage_direct_effect_id")]
        public int? DamageDirectEffectId { get; private set; }

        [Json("damage_head_multiplier")]
        public double? DamageHeadMultiplier { get; private set; }

        [Json("damage_indirect_effect_id")]
        public int? DamageIndirectEffectId { get; private set; }

        [Json("damage_legs_multiplier")]
        public double? DamageLegsMultiplier { get; private set; }

        [Json("fire_ammo_per_shot")]
        public int? FireAmmoPerShot { get; private set; }

        [Json("fire_auto_fire_ms")]
        public int? FireAutoFireMs { get; private set; }

        [Json("fire_burst_count")]
        public int? FireBurstCount { get; private set; }

        [Json("fire_charge_up_ms")]
        public int? FireChargeUpMs { get; private set; }

        [Json("fire_delay_ms")]
        public int? FireDelayMs { get; private set; }

        [Json("fire_detect_range")]
        public int? FireDetectRange { get; private set; }

        [Json("fire_duration_ms")]
        public int? FireDurationMs { get; private set; }

        [Json("fire_refire_ms")]
        public int? FireRefireMs { get; private set; }

        [Json("fire_pellets_per_shot")]
        public int? FirePelletsPerShot { get; private set; }

        [Json("heat_per_shot")]
        public int? HeatPerShot { get; private set; }

        [Json("heat_recovery_delay_ms")]
        public int? HeatRecoveryDelayMs { get; private set; }

        [Json("heat_threshold")]
        public int? HeatThreshold { get; private set; }

        [Json("lockon_acquire_close_ms")]
        public int? LockonAcquireCloseMs { get; private set; }

        [Json("lockon_acquire_far_ms")]
        public int? LockonAcquireFarMs { get; private set; }

        [Json("lockon_acquire_ms")]
        public int? LockonAcquireMs { get; private set; }

        [Json("lockon_angle")]
        public int? LockonAngle { get; private set; }

        [Json("lockon_lose_ms")]
        public int? LockonLoseMs { get; private set; }

        [Json("lockon_maintain")]
        public bool? LockonMaintain { get; private set; }

        [Json("lockon_radius")]
        public int? LockonRadius { get; private set; }

        [Json("lockon_range")]
        public int? LockonRange { get; private set; }

        [Json("lockon_range_close")]
        public int? LockonRangeClose { get; private set; }

        [Json("lockon_range_far")]
        public int? LockonRangeFar { get; private set; }

        [Json("lockon_required")]
        public bool? LockonRequired { get; private set; }

        [Json("recoil_angle_max")]
        public double? RecoilAngleMax { get; private set; }

        [Json("recoil_angle_min")]
        public double? RecoilAngleMin { get; private set; }

        [Json("recoil_first_shot_modifier")]
        public double? RecoilFirstShotModifier { get; private set; }

        [Json("recoil_horizontal_max")]
        public double? RecoilHorizontalMax { get; private set; }

        [Json("recoil_horizontal_max_increase")]
        public double? RecoilHorizontalMaxIncrease { get; private set; }

        [Json("recoil_horizontal_min")]
        public double? RecoilHorizontalMin { get; private set; }

        [Json("recoil_horizontal_min_increase")]
        public double? RecoilHorizontalMinIncrease { get; private set; }

        [Json("recoil_horizontal_tolerance")]
        public double? RecoilHorizontalTolerance { get; private set; }

        [Json("recoil_increase")]
        public double? RecoilIncrease { get; private set; }

        [Json("recoil_increase_crouched")]
        public double? RecoilIncreaseCrouched { get; private set; }

        [Json("recoil_magnitude_max")]
        public double? RecoilMagnitudeMax { get; private set; }

        [Json("recoil_magnitude_min")]
        public double? RecoilMagnitudeMin { get; private set; }

        [Json("recoil_max_total_magnitude")]
        public double? RecoilMaxTotalMagnitude { get; private set; }

        [Json("recoil_recovery_acceleration")]
        public int? RecoilRecoveryAcceleration { get; private set; }

        [Json("recoil_recovery_delay_ms")]
        public int? RecoilRecoveryDelayMs { get; private set; }

        [Json("recoil_recovery_rate")]
        public int? RecoilRecoveryRate { get; private set; }

        [Json("recoil_shots_at_min_magnitude")]
        public int? RecoilShotsAtMinMagnitude { get; private set; }

        [Json("reload_block_auto")]
        public bool? ReloadBlockAuto { get; private set; }

        [Json("reload_continuous")]
        public bool? ReloadContinuous { get; private set; }

        [Json("reload_ammo_fill_ms")]
        public int? ReloadAmmoFillMs { get; private set; }

        [Json("reload_chamber_ms")]
        public int? ReloadChamberMs { get; private set; }

        [Json("reload_loop_start_ms")]
        public int? ReloadLoopStartMs { get; private set; }

        [Json("reload_loop_end_ms")]
        public int? ReloadLoopEndMs { get; private set; }

        [Json("reload_time_ms")]
        public int? ReloadTimeMs { get; private set; }

        [Json("sway_amplitude_x")]
        public double? SwayAmplitudeX { get; private set; }

        [Json("sway_amplitude_y")]
        public double? SwayAmplitudeY { get; private set; }

        [Json("sway_can_steady")]
        public bool? SwayCanSteady { get; private set; }

        [Json("sway_period_x")]
        public int? SwayPeriodX { get; private set; }

        [Json("sway_period_y")]
        public int? SwayPeriodY { get; private set; }

        [Json("armor_penetration")]
        public int? ArmorPenetration { get; private set; }

        [Json("max_damage")]
        public int? MaxDamage { get; private set; }

        [Json("max_damage_ind")]
        public int? MaxDamageInd { get; private set; }

        [Json("max_damage_ind_radius")]
        public double? MaxDamageIndRadius { get; private set; }

        [Json("max_damage_range")]
        public int? MaxDamageRange { get; private set; }

        [Json("min_damage")]
        public int? MinDamage { get; private set; }

        [Json("min_damage_ind")]
        public int? MinDamageInd { get; private set; }

        [Json("min_damage_ind_radius")]
        public double? MinDamageIndRadius { get; private set; }

        [Json("min_damage_range")]
        public int? MinDamageRange { get; private set; }

        [Json("shield_bypass_pct")]
        public int? ShieldBypassPct { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }
    }
}
