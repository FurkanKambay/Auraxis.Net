using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Vehicle
    {
        [Json("vehicle_id")]
        public int VehicleId { get; private set; }

        [Json("name")]
        public LocalizedString Name { get; private set; }

        [Json("description")]
        public LocalizedString Description { get; private set; }

        [Json("type_id")]
        public int TypeId { get; private set; }

        [Json("type_name")]
        public string TypeName { get; private set; }

        [Json("cost")]
        public int? Cost { get; private set; }

        [Json("cost_resource_id")]
        public int CostResourceId { get; private set; }

        [Json("image_set_id")]
        public int ImageSetId { get; private set; }

        [Json("image_path")]
        public Uri ImagePath { get; private set; }
    }
}
