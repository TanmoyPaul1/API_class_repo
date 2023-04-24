using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Location
    {
        [Column("LocationID")]
        public int LocationID { get; set; }

        [Column("Country")]
        public string? Country { get; set; }

        [Column("City")]
        public string? City { get; set; }

        public List<Landmark> Landmark { get; set; } = new ();
    }
}