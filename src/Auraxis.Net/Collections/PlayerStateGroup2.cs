using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class PlayerStateGroup2
    {
        [Json("player_state_group_id")]
        public int Id { get; private set; }

        [Json("player_state_id")]
        public PlayerState PlayerState { get; private set; }

        [Json("can_iron_sight")]
        public bool CanIronSight { get; private set; }

        [Json("cof_grow_rate")]
        public int? ConeOfFireGrowRate { get; private set; }

        [Json("cof_max")]
        public double? MaxConeOfFire { get; private set; }

        [Json("cof_min")]
        public double? MinConeOfFire { get; private set; }

        [Json("cof_recovery_delay_ms")]
        public int? ConeOfFireRecoveryDelayMs { get; private set; }

        [Json("cof_recovery_rate")]
        public double? ConeOfFireRecoveryRate { get; private set; }

        [Json("cof_shots_before_penalty")]
        public int? ConeOfFireShotsBeforePenalty { get; private set; }

        [Json("cof_recovery_delay_threshold")]
        public int? ConeOfFireRecoveryDelayThreshold { get; private set; }

        [Json("cof_turn_penalty")]
        public int? ConeOfFireTurnPenalty { get; private set; }
    }
}
