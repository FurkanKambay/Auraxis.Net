using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Profile : ICountableCollection
    {
        [Json("profile_id")]
        public int Id { get; private set; }

        [Json("profile_type_id")]
        public ProfileType Type { get; private set; }

        [Json("profile_type_description")]
        public string TypeDescription { get; private set; }

        [Json("faction_id")]
        public Empire Faction { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }

        [Json("movement_speed")]
        public int MovementSpeed { get; private set; }

        [Json("backpedal_speed_modifier")]
        public double BackpedalSpeedModifier { get; private set; }

        [Json("sprint_speed_modifier")]
        public double SprintSpeedModifier { get; private set; }

        [Json("strafe_speed_modifier")]
        public double StrafeSpeedModifier { get; private set; }
    }
}
