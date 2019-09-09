using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace Auraxis.Net.EventStuff
{
    public class EventClient
    {
        /*
         * wss://push.planetside2.com/streaming?environment=[ps2|ps2ps4us|ps2ps4eu]&service-id=s:[your service id]
         *
         * 
         * 
         */

        /*
        # Character-centric events:
        Event 	                Description
        AchievementEarned 	    The given character has earned a new achievement (medal or ribbon)
        BattleRankUp 	        The given character has achieved a new battle rank
        Death 	                The given character has been killed
        ItemAdded 	            A character has been granted a new item
        SkillAdded 	            A character has been granted a skill/certification
        VehicleDestroy 	        A vehicle has been destroyed
        GainExperience 	        A player has gained experience. Match experience_id with http://census.daybreakgames.com/get/ps2/experience to find out what they did. Field other_id may refer to another player, or a vehicle, etc.

        * You can now filter GainExperience events by experience_id. Details here.
        PlayerFacilityCapture 	A player has taken part in capturing a facility.
        PlayerFacilityDefend 	A player has taken part in defending a facility.

        # World-centric events:
        Event 	                Description
        ContinentLock 	        A continent has been locked
        ContinentUnlock 	    A continent has been unlocked
        FacilityControl 	    A facility has changed hands
        MetagameEvent 	        A metagame event (alert) has started or ended

        # Character-centric and world-centric events:
        Event 	                Description
        PlayerLogin 	        A character has logged into game
        PlayerLogout 	        A character has logged out of game
        */

        public ClientWebSocket Client { get; set; }

        public EventClient()
        {
            Client = new ClientWebSocket();

        }

        //public static event Action PlayerLogin
        //{
        //    add => Subscribe();
        //    remove => Unsubscribe();
        //}

        //public static event Action PlayerLogout
        //{
        //    add => Subscribe();
        //    remove => Unsubscribe();
        //}

        //public static List<string> Log = new List<string>();

        //private static void Subscribe([CallerMemberName] string eventName = "") => Log.Add($"Subscribe: {eventName}");
        //private static void Unsubscribe([CallerMemberName] string eventName = "") => Log.Add($"Unsubscribe: {eventName}");
    }
}
