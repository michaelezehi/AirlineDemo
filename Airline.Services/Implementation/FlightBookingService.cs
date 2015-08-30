using System;
using System.Collections.Generic;
using System.Linq;
using Airline.Domain;
using Airline.Domain.enums;
using Airline.Services.Interfaces;

namespace Airline.Services.Implementation
{
    public class FlightBookingService : IFlightBookingService
    {
        private FlightDetails _flightDetails;
        private const decimal _extraBaggageCost = 75M;
        private const int _defaultBaggageQuantitiy = 1;
        private const int _loyaltyMemberMaxBaggageQuantitiy = 2;

        public decimal TotalFlightRevenue
        {
            get
            {
                var totalFlightRevenue = _flightDetails.Passengers.Sum(x => TotalBookingPrice(x.FirstName));
                return totalFlightRevenue;
            }
        }


        public void BookFlight(FlightDetails flightDetails)
        {
            _flightDetails = flightDetails;
            GrantAccessToPassengersIntoPlane(_flightDetails.Passengers);
        }

        private void GrantAccessToPassengersIntoPlane(IEnumerable<PassengerDetails> passengers)
        {
            if (_flightDetails.AirPlaneDetails == null)
                return;
            var airplaneCount = _flightDetails.AirPlaneDetails.NumberOfSeats;
            passengers.Take(airplaneCount).ToList().ForEach(
                (p) =>
                {
                    p.CanBoardFlight = true;
                });
        }


        public decimal GetPassengerDiscount(string passengerName)
        {
            var passenger = _flightDetails.Passengers.First(x => x.FirstName == passengerName);
            var flightDiscount = passenger.IsUsingLoyaltyPoint ? passenger.LoyaltyPoints : 0;
            return flightDiscount;
        }

        public bool CanDepart()
        {
            var result = CalculateFlightPercentage();
            return result >= 75;
        }

        public decimal TotalBookingPrice(string passengerName)
        {
            var passenger = _flightDetails.Passengers.First(x => x.FirstName == passengerName);
            if (IsAirlineEmployee(passenger))
                return 0;

            var discount = GetPassengerDiscount(passengerName);
            var flightCost = _flightDetails.TicketBasePrice + CalculateAdditionalBaggageCharges(passenger);

            return flightCost - discount;
        }

        private static bool IsAirlineEmployee(PassengerDetails passenger)
        {
            return passenger.PassengerType == PassengerType.Employee;
        }

        private decimal CalculateFlightPercentage()
        {
            decimal flightCapacity = _flightDetails.AirPlaneDetails.NumberOfSeats;
            decimal numberOfPassengers = _flightDetails.Passengers.Count();

            var result = Math.Round((numberOfPassengers / flightCapacity) * 100M);

            return result;
        }

        private static decimal CalculateAdditionalBaggageCharges(PassengerDetails passenger)
        {
            if (passenger.Baggage <= _defaultBaggageQuantitiy)
                return 0;

            int additionalBaggage;
            if (IsNotLoyaltyMemberAndIsNotUsingExtraBaggageAllowance(passenger))
            {
                additionalBaggage = passenger.Baggage - _defaultBaggageQuantitiy;
                return _extraBaggageCost * additionalBaggage;
            }

            if (IsLoyaltyMemberAndWithinBaggageAllowance(passenger))
                return 0;

            additionalBaggage = passenger.Baggage - _loyaltyMemberMaxBaggageQuantitiy;
            return _extraBaggageCost * additionalBaggage;
        }

        private static bool IsLoyaltyMemberAndWithinBaggageAllowance(PassengerDetails passenger)
        {
            return passenger.Baggage <= _loyaltyMemberMaxBaggageQuantitiy;
        }

        private static bool IsNotLoyaltyMemberAndIsNotUsingExtraBaggageAllowance(PassengerDetails passenger)
        {
            return passenger.PassengerType != PassengerType.Loyalty ||
                   !passenger.IsUsingExtraBaggageAllowance;
        }

    }
}