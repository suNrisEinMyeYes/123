using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPart
{
    class Hatch
    {
        public GPSLocation location;
        public Vector3 position;
        public bool isDrawed { get; set; }
        public bool toDelete { get; set; }
        public string description { get; set; }
        public string model;

    }
}
