using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPSWebApi.Models
{
    public class Tile
    {
        public int id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public string type { get; set; }
        public int x { get; set; }

        public int y { get; set; }
        public int gold { get; set; }
        public int food { get; set; }
        public int production { get; set; }
        public int culture { get; set; }
        public int faith { get; set; }
        public int science { get; set; }
        public string improvement { get; set; }
    }
}