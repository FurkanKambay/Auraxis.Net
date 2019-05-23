using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ProjectileFlightType
    {
        [Json("projectile_flight_type_id")]
        public int ProjectileFlightTypeId { get; private set; }

        [Json("description")]
        public string Description { get; private set; }
    }
}
