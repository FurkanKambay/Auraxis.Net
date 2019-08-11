using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class DirectiveTier
    {
        [Json("directive_tree_id")]
        public int DirectiveTreeId { get; private set; }

        [Json("directive_tier_id")]
        public int Id { get; private set; }

        [Json("directive_points")]
        public int DirectivePoints { get; private set; }

        [Json("completion_count")]
        public int CompletionCount { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }

        [Json("reward_set_id")]
        public int? RewardSetId { get; private set; }
    }
}
