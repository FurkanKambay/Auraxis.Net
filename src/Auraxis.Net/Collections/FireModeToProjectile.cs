using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class FireModeToProjectile
    {
        [Json("fire_mode_id")]
        public int FireModeId { get; private set; }

        [Json("projectile_id")]
        public int ProjectileId { get; private set; }
    }
}
