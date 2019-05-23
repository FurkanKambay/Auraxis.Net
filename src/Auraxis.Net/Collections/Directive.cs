using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Directive
    {
        [Json("directive_id")]
        public int DirectiveId { get; private set; }

        [Json("directive_tree_id")]
        public int DirectiveTreeId { get; private set; }

        [Json("directive_tier_id")]
        public int DirectiveTierId { get; private set; }

        [Json("objective_set_id")]
        public int ObjectiveSetId { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }

        [Json("qualify_requirement_id")]
        public int QualifyRequirementId { get; private set; }
    }
}
