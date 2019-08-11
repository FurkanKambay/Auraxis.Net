using System.Runtime.Serialization;

namespace Auraxis.Net
{
    public enum Platform
    {
        PC,
        PS4_EU,
        PS4_US
    }

    public enum Server
    {
        Connery = 1,
        Miller = 10,
        Cobalt = 13,
        Emerald = 17,
        Jaeger = 19,
        Briggs = 25,
        SolTech = 40,
        Genudine = 1000,
        Ceres = 2000
    }

    public enum Continent
    {
        Indar = 2,
        Hossin = 4,
        Amerish = 6,
        Esamir = 8,
        Nexus = 10,
        Koltyr = 14,
        QAZone = 59,
        Tutorial = 95,
        VRTrainingZoneNC = 96,
        VRTrainingZoneTR = 97,
        VRTrainingZoneVS = 98,
        CleanRoom = 200,
        Unnamed = 309
    }

    public enum Empire
    {
        None = 0,
        [EnumMember(Value = "VS")] VanuSovereignty = 1,
        [EnumMember(Value = "NC")] NewConglomerate = 2,
        [EnumMember(Value = "TR")] TerranRepublic = 3,
        [EnumMember(Value = "NSO")] NsOperatives = 4
    }

    public enum ArmorFacing
    {
        Front = 0,
        Right = 1,
        Top = 2,
        Rear = 3,
        Left = 4,
        Bottom = 5
    }

    public enum TargetType
    {
        Self = 1,
        Any = 2,
        Enemy = 3,
        Ally = 4
    }

    public enum WorldState
    {
        Online,
        Locked
    }

    public enum MapHexType
    {
        UnrestrictedAccess = 0,
        RestrictedByFaction = 2
    }

    public enum ProfileType
    {
        Infiltrator = 1,
        LightAssault = 3,
        CombatMedic = 4,
        Engineer = 5,
        HeavyAssault = 6,
        Max = 7
    }

    public enum PlayerState
    {
        Standing = 0,
        Crouching = 1,
        Running = 2,
        Sprinting = 3,
        [EnumMember(Value = "Falling Long")] FallingLong = 4,
        CrouchWalking = 5
    }

    public enum FacilityType
    {
        Default = 1,
        AmpStation = 2,
        BioLab = 3,
        TechPlant = 4,
        LargeOutpost = 5,
        SmallOutpost = 6,
        Warpgate = 7,
        InterlinkFacility = 8,
        ConstructionOutpost = 9
    }

    public enum OutfitMemberRank
    {
        Leader = 1,
        Officer = 2,
        Member = 3,
        Private = 4,
        Recruit = 5
    }

    public enum MetagameEventState
    {
        Started = 135,
        Restarted = 136,
        Canceled = 137,
        Ended = 138,
        XpBonusChanged = 129
    }
}
