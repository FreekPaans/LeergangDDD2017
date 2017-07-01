namespace Hotel.Domain
{
    public interface IDayOccupancyRepo
    {
        DayOccupancyAggregate FindOrDefault(Date forDate);
        void Save(DayOccupancyAggregate occupancy);
    }
}