using System.Collections.ObjectModel;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace Auraxis.Net
{
    // public class SingleCharacterById : ICollection { }
    // public class Leaderboard : ICollection { }
    // public class CharactersLeaderboard : ICollection { }
    // public class CharactersEventGrouped : ICollection { }
    // public class CharactersEvent { }
    // public class Event : ICollection { }
    // public class WorldEvent { }

    // [NoCommandsSupported]
    // : ICollection
    public class Map : ICollection
    {
        [Json("ZoneId")]
        public Continent Zone { get; set; }

        [Json("Regions")]
        public SpecialRegion Regions { get; set; }
    }


    public class SpecialRegion
    {
        [Json("IsList")]
        public bool IsList { get; set; }

        [Json("Row.RowData")]
        public ReadOnlyCollection<RowData> Rows { get; set; }
    }

    // public class Row
    // {
    //     [Json("RowData")]
    //     public RowData RowData { get; set; }
    // }

    public class RowData
    {
        [Json("RegionId")]
        public int RegionId { get; set; }

        [Json("FactionId")]
        public Empire Faction { get; set; }
    }
}
