using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSPlus
{
    public class StreetMap
    {
        public string Name;
        public float X, Y, Z;
        public Vector3 Location {
            get {
                return new Vector3(X, Y, Z);
            }
        }

        public StreetMap(string name, float x, float y, float z)
        {
            Name = name;
            X = x;
            Y = y;
            Z = z;
        }
    }
}
