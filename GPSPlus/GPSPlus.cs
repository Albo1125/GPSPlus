using CitizenFX.Core;
using CitizenFX.Core.Native;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace GPSPlus
{
    public class GPSPlus : BaseScript
    {

        public static StreetMap[] streetMappings;
        
        public GPSPlus()
        {
            EventHandlers["GPSPlus:Search"] += new Action<string>((string streetname) =>
            {
                streetname = streetname.Trim();
                StreetMap sm = matchSearch(streetname);
                if (sm != null)
                {
                    World.WaypointPosition = sm.Location;
                    TriggerEvent("chatMessage", "GPSPlus", new int[] { 255, 255, 0 }, "Destination set to: " + sm.Name);
                }
                else
                {
                    World.RemoveWaypoint();
                    TriggerEvent("chatMessage", "GPSPlus", new int[] { 255, 255, 0 }, "Destination cleared.");
                }
            });

            string resourceName = API.GetCurrentResourceName();
            string streetmappingsjson = API.LoadResourceFile(resourceName, "streetmappings.json");
            streetMappings = JsonConvert.DeserializeObject<StreetMap[]>(streetmappingsjson);
        }

        public StreetMap matchSearch(string query)
        {
            StreetMap sm = streetMappings.Where(x => x.Name?.ToLower() == query.ToLower()).FirstOrDefault();
            if (sm == null && !string.IsNullOrWhiteSpace(query))
            {
                string firstword = query.Split(null)[0].ToLower();
                sm = streetMappings.Where(x => x.Name?.ToLower().Split(null)[0] == firstword).FirstOrDefault();
            }
            return sm;
        }
    }
}
