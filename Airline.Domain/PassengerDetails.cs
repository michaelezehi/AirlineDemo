using Airline.Domain.enums;

namespace Airline.Domain
{
    public class PassengerDetails
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public PassengerType PassengerType { get; set; }
        public int LoyaltyPoints { get; set; }
        public bool IsUsingLoyaltyPoint { get; set; }
        public bool IsUsingExtraBaggageAllowance { get; set; }

        public int Baggage { get; set; }

        public bool CanBoardFlight { get; set; }
    }
}
