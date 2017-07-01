using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class DayOccupancyRepo : IDayOccupancyRepo
    {
        public DayOccupancyAggregate FindOrDefault(Date forDate)
        {
            var ctx = new HotelDbContext();

            var record = ctx.DayOccupancyRecords.Find(forDate.ToString());

            if(record==null)
            {
                return DayOccupancyAggregate.Empty(forDate);
            }

            return DayOccupancyAggregate.Hydrate(
                    forDate: forDate,
                    reservationCount: record.ReservationCount,
                    version: record.Version);
        }

        public void Save(DayOccupancyAggregate occupancy)
        {
            var ctx = new HotelDbContext();

            if (occupancy.Version == null)
            {
                ctx.DayOccupancyRecords.Add(new DayOccupancyRecord
                {
                    ForDate = occupancy.ForDate.ToString(),
                    ReservationCount = occupancy.ReservationCount
                });
                ctx.SaveChanges();
                return;
            }

            var record = ctx.DayOccupancyRecords.Find(occupancy.ForDate.ToString());

            record.Version = occupancy.Version;
            record.ReservationCount = occupancy.ReservationCount;

            ctx.SaveChanges();
        }
    }
}
