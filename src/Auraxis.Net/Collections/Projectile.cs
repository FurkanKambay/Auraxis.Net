using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Projectile
    {
        [Json("projectile_id")]
        public int Id { get; private set; }

        [Json("projectile_flight_type_id")]
        public int FlightTypeId { get; private set; }

        [Json("speed")]
        public int Speed { get; private set; }

        [Json("speed_max")]
        public int? SpeedMax { get; private set; }

        [Json("acceleration")]
        public double? Acceleration { get; private set; }

        [Json("turn_rate")]
        public double? TurnRate { get; private set; }

        [Json("lifespan")]
        public double Lifespan { get; private set; }

        [Json("drag")]
        public double? Drag { get; private set; }

        [Json("gravity")]
        public double? Gravity { get; private set; }

        [Json("lockon_acceleration")]
        public double? LockonAcceleration { get; private set; }

        [Json("lockon_lifespan")]
        public double? LockonLifespan { get; private set; }

        [Json("arm_distance")]
        public int? ArmDistance { get; private set; }

        [Json("tether_distance")]
        public int? TetherDistance { get; private set; }

        [Json("detonate_distance")]
        public int? DetonateDistance { get; private set; }

        [Json("detonate_on_contact")]
        public bool? DetonateOnContact { get; private set; }

        [Json("sticky")]
        public bool? IsSticky { get; private set; }

        [Json("sticks_to_players")]
        public bool? SticksToPlayers { get; private set; }

        [Json("lockon_lose_angle")]
        public int? LockonLoseAngle { get; private set; }

        [Json("lockon_seek_in_flight")]
        public bool? LockonSeekInFlight { get; private set; }
    }
}
