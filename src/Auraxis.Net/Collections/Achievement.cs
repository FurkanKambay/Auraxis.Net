using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Achievement
    {
        [Json("achievement_id")]
        public int Id { get; private set; }

        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("objective_group_id")]
        public int ObjectiveGroupId { get; private set; }

        [Json("reward_id")]
        public int RewardId { get; private set; }

        [Json("repeatable")]
        public bool IsRepeatable { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }
    }
}
