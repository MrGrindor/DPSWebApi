using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPSWebApi.Models
{
    public class City
    {
        public int Id { get; set; }
        public int Population { get; set; }
        public int Specialist { get; set; }
        public int Buildings { get; set; }
        public int Wonders { get; set; }

        public Tile HomeTile { get; set; }
        public string HomeTileId { get; set; }


    }
}