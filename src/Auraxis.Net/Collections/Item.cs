using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Item
    {
        [Json("item_id")]
        public int ItemId { get; private set; }

        [Json("item_type_id")]
        public int ItemTypeId { get; private set; }

        [Json("item_category_id")]
        public int? ItemCategoryId { get; private set; }

        [Json("activatable_ability_id")]
        public int? ActivatableAbilityId { get; private set; }

        [Json("passive_ability_id")]
        public int? PassiveAbilityId { get; private set; }

        [Json("is_vehicle_weapon")]
        public bool IsVehicleWeapon { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("faction_id")]
        public Empire FactionId { get; private set; }

        [Json("max_stack_size")]
        public int MaxStackSize { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }

        [Json("skill_set_id")]
        public int? SkillSetId { get; private set; }

        [Json("is_default_attachment")]
        public bool IsDefaultAttachment { get; private set; }
    }
}
