using Hotel.DAL;
using Hotel.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Hotel.Tests
{
    [TestClass]
    public class ReservationTests
    {
        private ReservationAppService _reservationService;

        [TestInitialize]
        public void Init()
        {
            _reservationService = new ReservationAppService(new ReservationRepository(), new DayOccupancyRepo());
        }

        [TestMethod]
        public void can_make_a_reservation()
        {
            _reservationService.MakeReservation(
                    forDate:Date.Today, 
                    reservationId:NewReservationId(), 
                    name: "Roeland",
                    phone: "07123");
        }

        [TestMethod]
        public void cannot_make_more_than_10_reservations_on_a_single_day()
        {
            foreach(var i in Enumerable.Range(0,10))
            {
                _reservationService.MakeReservation(
                    forDate: Date.Today,
                    reservationId: NewReservationId(),
                    name: "Roeland " + i,
                    phone: "06123");
            }

            try {
                _reservationService.MakeReservation(
                    forDate: Date.Today,
                    reservationId: NewReservationId(),
                    name: "Roeland 11",
                    phone: "07123");
            }
            catch(InvalidOperationException _)
            {
                return;
            }

            Assert.Fail("Should not be able to make more than 10 reservations, made 11");
        }

        private static string NewReservationId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
