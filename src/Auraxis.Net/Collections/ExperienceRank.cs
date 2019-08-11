using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    public class ExperienceRank
    {
        [Json("rank")]
        public int Rank { get; private set; }

        [Json("xp_max")]
        public double MaxExperience { get; private set; }

        [Json("vs")]
        public Rank Vs { get; private set; }

        [Json("vs_image_path")]
        public Uri VsImagePath { get; private set; }

        [Json("nc")]
        public Rank Nc { get; private set; }

        [Json("nc_image_path")]
        public Uri NcImagePath { get; private set; }

        [Json("tr")]
        public Rank Tr { get; private set; }

        [Json("tr_image_path")]
        public Uri TrImagePath { get; private set; }
    }
}
