using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class PlayerStateGroup2
    {
        [Json("player_state_group_id")]
        public int PlayerStateGroupId { get; private set; }

        [Json("player_state_id")]
        public int PlayerStateId { get; private set; }

        [Json("can_iron_sight")]
        public bool CanIronSight { get; private set; }

        [Json("cof_grow_rate")]
        public int? CofGrowRate { get; private set; }

        [Json("cof_max")]
        public double? CofMax { get; private set; }

        [Json("cof_min")]
        public double? CofMin { get; private set; }

        [Json("cof_recovery_delay_ms")]
        public int? CofRecoveryDelayMs { get; private set; }

        [Json("cof_recovery_rate")]
        public double? CofRecoveryRate { get; private set; }

        [Json("cof_shots_before_penalty")]
        public int? CofShotsBeforePenalty { get; private set; }

        [Json("cof_recovery_delay_threshold")]
        public int? CofRecoveryDelayThreshold { get; private set; }

        [Json("cof_turn_penalty")]
        public int? CofTurnPenalty { get; private set; }
    }
}
