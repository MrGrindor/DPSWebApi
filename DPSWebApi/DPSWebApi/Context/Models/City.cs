using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPSWebApi.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public int Population { get; set; }
        public int Specialist { get; set; }
        public int Buildings { get; set; }
        public int Wonders { get; set; }

        public Tile HomeTile { get; set; }
        public int HomeTileId { get; set; }


    }
}