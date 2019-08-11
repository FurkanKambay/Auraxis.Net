using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class Objective : ParamsBaseP9, ICountableCollection
    {
        [Json("objective_id")]
        public int Id { get; private set; }

        [Json("objective_type_id")]
        public int TypeId { get; private set; }

        [Json("objective_group_id")]
        public int GroupId { get; private set; }
    }
}
