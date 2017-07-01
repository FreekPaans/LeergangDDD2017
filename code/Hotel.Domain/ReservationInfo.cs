using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain
{
    class ReservationInfoAggregate
    {
        public Date ForDate { get; }
        public string ReservationId { get; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public ReservationInfoAggregate(Date forDate, string reservationId)
        {
            ForDate = forDate;
            ReservationId = reservationId;
        }
    }
}
