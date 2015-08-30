using System.Collections.Generic;
using Airline.Domain.enums;

namespace Airline.Domain
{
    public class FlightDetails
    {
        public decimal TicketBasePrice { get; set; }

        public decimal PassengerCost { get; set; }

        public string Origin { get; set; }
        public string Destination { get; set; }
        public AirPlaneDetails AirPlaneDetails { get; set; }

        public List<PassengerDetails> Passengers { get; set; }
    }


}
