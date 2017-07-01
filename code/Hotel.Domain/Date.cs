using System;

namespace Hotel.Domain
{
    public class Date
    {
        readonly DateTime _dt;

        Date(DateTime dt)
        {
            _dt = dt;
        }

        public static Date Today => new Date(DateTime.Today);
    }
}