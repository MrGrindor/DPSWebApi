using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPSWebApi.Models
{
    public class Tile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Type { get; set; }
        public int PosX { get; set; }

        public int PosY { get; set; }
        public int Gold { get; set; }
        public int Food { get; set; }
        public int Production { get; set; }
        public int Culture { get; set; }
        public int Faith { get; set; }
        public int Science { get; set; }
        public string Improvement { get; set; }

        public City CityOnTile { get; set; }

    }
}