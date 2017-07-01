using System.Data.Entity;

namespace Hotel.DAL {
    public class HotelDbContext : DbContext {
        public HotelDbContext()
            : base("HotelDbContext") {
        }

        public DbSet<EmployeeRecord> EmployeeRecords { get; set; }
        public DbSet<DayOccupancyRecord> DayOccupancyRecords { get; set; }
    }
}
