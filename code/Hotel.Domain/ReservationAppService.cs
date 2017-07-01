using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain
{
    public class ReservationAppService
    {
        private readonly IReservationRepository _resRepo;
        private readonly IDayOccupancyRepo _occRepo;

        public ReservationAppService(IReservationRepository resRepo, IDayOccupancyRepo occRepo)
        {
            _resRepo = resRepo;
            _occRepo = occRepo;
        }

        public void MakeReservation(Date forDate, string reservationId, string name, string phone)
        {
            var occupancy = _occRepo.FindOrDefault(forDate);

            occupancy.MakeReservation();

            _occRepo.Save(occupancy);
        }
    }
}
