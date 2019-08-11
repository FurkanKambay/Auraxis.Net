using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Effect : ParamsBaseP13
    {
        [Json("effect_id")]
        public int Id { get; private set; }

        [Json("effect_type_id")]
        public int TypeId { get; private set; }

        [Json("ability_id")]
        public int? AbilityId { get; private set; }

        [Json("target_type_id")]
        public int TargetTypeId { get; private set; }

        [Json("resist_type_id")]
        public int ResistTypeId { get; private set; }

        [Json("is_drain")]
        public bool? IsDrain { get; private set; }

        [Json("duration_seconds")]
        public int? DurationSeconds { get; private set; }
    }
}
