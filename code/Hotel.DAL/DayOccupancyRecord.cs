using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class DayOccupancyRecord
    {
        [Key]
        public string ForDate { get; set; }

        public int ReservationCount { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
