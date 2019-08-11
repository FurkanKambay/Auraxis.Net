using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FireGroup : ICountableCollection
    {
        [Json("fire_group_id")]
        public int Id { get; private set; }

        [Json("transition_duration_ms")]
        public int? TransitionDurationMs { get; private set; }

        [Json("chamber_duration_ms")]
        public int? ChamberDurationMs { get; private set; }

        [Json("can_chamber_ironsights")]
        public bool? CanChamberIronsights { get; private set; }

        [Json("spool_up_ms")]
        public int? SpoolUpMs { get; private set; }

        [Json("spool_up_initial_refire_ms")]
        public int? SpoolUpInitialRefireMs { get; private set; }
    }
}
