using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain
{
    public class DayOccupancyAggregate
    {
        public Date ForDate { get; }
        public int ReservationCount { get; private set; }
        public byte[] Version { get; }

        DayOccupancyAggregate(Date forDate, int reservationCount, byte[] version)
        {
            ForDate = forDate;
            Version = version;
            ReservationCount = reservationCount;
        }

        public void MakeReservation()
        {
            if(ReservationCount>=10)
            {
                throw new InvalidOperationException("Cannot make more reservations");
            }
            ReservationCount++;
        }

        public static DayOccupancyAggregate Hydrate(Date forDate, int reservationCount, byte[] version)
        {
            return new DayOccupancyAggregate(forDate, reservationCount, version);
        }

        public static DayOccupancyAggregate Empty(Date forDate)
        {
            return new DayOccupancyAggregate(forDate, reservationCount: 0, version: null);
        }
    }
}
