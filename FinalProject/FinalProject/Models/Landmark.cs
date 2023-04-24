using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Landmark
    {
        [Column("LandmarkID")]
        public int LandmarkID { get; set; }

        [Column("LandmarkName")]
        public string? LandmarkName { get; set; }

        [Column("Rating")]
        public float? Rating { get; set; }

        [Column("HotelCount")]
        public int? HotelCount { get; set; }

        [Column("AvgTicketPrice")]
        public float? AvgTicketPrice { get; set; }

        public int LocationID { get; set; } 
    }
}