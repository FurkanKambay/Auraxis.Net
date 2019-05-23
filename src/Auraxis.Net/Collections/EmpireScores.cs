using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class EmpireScores
    {
        [Json("tracker_name")]
        public string TrackerName { get; private set; }

        [Json("tracker_description")]
        public string TrackerDescription { get; private set; }

        [Json("start_date")]
        public DateTimeOffset StartDate { get; private set; }

        [Json("end_date")]
        public DateTimeOffset EndDate { get; private set; }

        [Json("name")]
        public Name Name { get; private set; }
    }
}
