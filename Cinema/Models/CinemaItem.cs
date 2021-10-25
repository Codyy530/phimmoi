using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class ShowTime
    {
        public string showtime { get; set; }
    }
    public class CinemaItem1
    {
        [StringLength(100)]
        public string CinemaName { get; set; }

        [StringLength(100)]
        public string CinemaAddress { get; set; }
        

        public virtual List<ShowTime> type1 { get; set; }
        public virtual List<ShowTime> type2 { get; set; }
        public virtual List <ShowTime> type3 { get; set; }
    }
    public class MovieItem
    {
        [StringLength(50)]
        public string MovieName { get; set; }

        [StringLength(50)]
        public string Director { get; set; }

        [StringLength(100)]
        public string Actor { get; set; }

        [StringLength(30)]
        public string Category { get; set; }

        public double? IMDb { get; set; }

        public byte? MovieLength { get; set; }

        public byte? Rate { get; set; }

     

        [StringLength(100)]
        public string PosterLink { get; set; }


        public virtual List<ShowTime> type1 { get; set; }
        public virtual List<ShowTime> type2 { get; set; }
        public virtual List <ShowTime> type3 { get; set; }
    }
    
}