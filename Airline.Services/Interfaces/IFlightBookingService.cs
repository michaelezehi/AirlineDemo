using Airline.Domain;

namespace Airline.Services.Interfaces
{
    public interface IFlightBookingService
    {
        void BookFlight(PassengerDetails passengerDetails);
        decimal GetPassengerDiscount(string passengerName);
        decimal TotalBookingPrice(string passengerName);
        bool CanDepart();
        decimal TotalFlightRevenue { get; }
    }

}