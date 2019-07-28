namespace Auraxis.Net
{
    // Exceptions
    // Can only be queried by 'character_id = x' or equivalently 'id = x'.
    // None of the 'c:' commands are supported (except c:join, c:tree).
    // Only 'get' is supported, 'count' is not.
    //public class SingleCharacterById { }

    // Exceptions
    // Can only be queried by 'name = x' (required), 'period = x' (required), 'world = [world_id]' (optional).
    // Possible values for name are: Kills, Score, Time, Deaths.
    // Possible value for period are: Forever, Monthly, Weekly, Daily, OneLife.
    // The only 'c:' commands supported are c:start and c:limit (also c:join, c:tree).
    // Only 'get' is supported, 'count' is not.
    //public class Leaderboard { }

    // Exceptions
    // Limitations are the same as those for leaderboard except 'character_id = x,y,z...' or equivalently 'id = x,y,z...' are used to limit the characters returned.
    // Please note that only the top 10,000 characters are in the leaderboard data, many characters will not have a leaderboard row.
    // Only 'get' is supported, 'count' is not.
    //public class CharactersLeaderboard { }

    // Exceptions
    // Can only be queried by 'character_id = x,y,z...' or equivalently 'id = x,y,z...' and 'type = [DEATH | KILL]'.
    // Multiple types can be provided comma-delimited. The default value type is 'DEATH,KILL'.
    // The only 'c:' commands supported are c:start and c:limit (also c:join, c:tree).
    // Only 'get' is supported, 'count' is not.
    //public class CharactersEventGrouped { }

    // Exceptions
    // Limitations are the same as those for event except 'character_id = x,y,z...' or equivalently 'id = x,y,z...' are used to limit the rows returned.
    //public class CharactersEvent { }

    // Exceptions
    // Can only be queried by before, after and type. 'before = [timestamp]', 'after = [timestamp]'.
    // The default value of after is 0.
    // The after query field is provided for polling purposes.
    // The before query field can be used to pull all rows by stepping through them backwards. 'type = [BATTLE_RANK | ITEM | ACHIEVEMENT | DEATH | KILL | VEHICLE_DESTROY | FACILITY_CHARACTER]'.
    // Multiple types can be provided comma-delimited. The default value type is 'BATTLE_RANK,ACHIEVEMENT,ITEM'.
    // The only 'c:' command supported is c:limit (also c:join, c:tree).
    // Only 'get' is supported, 'count' is not.
    //public class Event { }

    // Exceptions
    // Can only be queried by 'world_id = x' and 'zone_ids = x,y,z...'.
    // None of the 'c:' commands are supported (except c:join, c:tree).
    // Only 'get' is supported, 'count' is not.
    //public class Map { }

    // Exceptions
    // Limitations are the same as those for event except 'world_id = x,y,z...' or equivalently 'id = x,y,z...' are used to limit the rows returned.
    //public class WorldEvent { }

    // day.d01-d31, month.m01-m12, week.w01-w13
    public class CharactersStatHistory { }
    public class WorldStatHistory { }

    // param1-param14, string1-string4, conditional properties
    public class Ability { }
    public class AbilityType { }

    // many properties
    public class FireMode { }
    public class FireMode2 { }

    // conditional properties
    public class Projectile { }
    public class Weapon { }
    public class WeaponDatasheet { }
}
