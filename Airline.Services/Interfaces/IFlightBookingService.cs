using Airline.Domain;

namespace Airline.Services.Interfaces
{
    public interface IFlightBookingService
    {
        decimal TotalFlightRevenue { get; }

        void BookFlight(PassengerDetails passengerDetails);
        decimal GetPassengerDiscount(string passengerName);
        decimal TotalBookingPrice(string passengerName);
        bool CanDepart();
        dynamic PrintFlightSummary();

    }

}