using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Weapon : ICountableCollection
    {
        [Json("weapon_id")]
        public int Id { get; private set; }

        [Json("weapon_group_id")]
        public int? GroupId { get; private set; }

        [Json("turn_modifier")]
        public double? TurnModifier { get; private set; }

        [Json("move_modifier")]
        public double? MoveModifier { get; private set; }

        [Json("sprint_recovery_ms")]
        public int? SprintRecoveryMs { get; private set; }

        [Json("equip_ms")]
        public int? EquipMs { get; private set; }

        [Json("unequip_ms")]
        public int? UnequipMs { get; private set; }

        [Json("to_iron_sights_ms")]
        public int? ToIronSightsMs { get; private set; }

        [Json("from_iron_sights_ms")]
        public int? FromIronSightsMs { get; private set; }

        [Json("heat_capacity")]
        public int? HeatCapacity { get; private set; }

        [Json("heat_bleed_off_rate")]
        public double? HeatBleedOffRate { get; private set; }

        [Json("heat_overheat_penalty_ms")]
        public int? HeatOverheatPenaltyMs { get; private set; }

        [Json("melee_detect_width")]
        public double? MeleeDetectWidth { get; private set; }

        [Json("melee_detect_height")]
        public double? MeleeDetectHeight { get; private set; }
    }
}
