using System;
using System.Collections.Generic;
using System.Linq;
using Airline.Domain;
using Airline.Domain.enums;
using Airline.Services.Interfaces;

namespace Airline.Services.Implementation
{
    public class FlightBookingService : IFlightBookingService, IPrintingService
    {
        private readonly FlightDetails _flightDetails;
        private const decimal _extraBaggageCost = 75M;
        private const int _defaultBaggageQuantitiy = 1;
        private const int _minimumPlaneCapacity = 75;
        private const int _loyaltyMemberMaxBaggageQuantitiy = 2;
        private const decimal _airFlightCost = 150;


        public FlightBookingService(FlightDetails flightDetails)
        {
            _flightDetails = flightDetails;
            _flightDetails.Passengers = new List<PassengerDetails>();
        }

        public decimal TotalFlightRevenue
        {
            get
            {
                var totalFlightRevenue = _flightDetails.Passengers.Sum(x => TotalBookingPrice(x.FirstName));
                return totalFlightRevenue;
            }
        }

        public void BookFlight(PassengerDetails passengerDetails)
        {
            _flightDetails.Passengers.Add(passengerDetails);
            GrantAccessToPassengersIntoPlane(_flightDetails.Passengers);
        }

        public decimal GetPassengerDiscount(string passengerName)
        {
            var passenger = _flightDetails.Passengers.First(x => x.FirstName == passengerName);
            var flightDiscount = passenger.IsUsingLoyaltyPoint ? passenger.LoyaltyPoints : 0;
            return flightDiscount;
        }

        public bool CanDepart()
        {
            var currentPlaneCapacity = CalculateFlightPercentage();
            return currentPlaneCapacity >= _minimumPlaneCapacity;
        }

        public decimal TotalBookingPrice(string passengerName)
        {
            var passenger = _flightDetails.Passengers.FirstOrDefault(x => x.FirstName == passengerName);
            if (IsAirlineEmployee(passenger))
                return 0;

            var discount = GetPassengerDiscount(passengerName);
            var flightCost = _flightDetails.TicketBasePrice + CalculateAdditionalBaggageCharges(passenger);

            return flightCost - discount;
        }

        public dynamic Print()
        {
            return $"total-passenger-count: {_flightDetails.Passengers.Count}\r\n" +
                   $"general-passenger-count: {_flightDetails.Passengers.Count(x => x.PassengerType == PassengerType.General)}\r\n" +
                   $"airline-passenger-count: {_flightDetails.Passengers.Count(x => x.PassengerType == PassengerType.Employee)}\r\n" +
                   $"loyalty-passenger-count : {_flightDetails.Passengers.Count(x => x.PassengerType == PassengerType.Loyalty)}\r\n" +
                   $"total-number-of-bags:  {_flightDetails.Passengers.Sum(x => x.Baggage)}\r\n" +
                   $"total-loyalty-points-redeemed: {_flightDetails.Passengers.Where(x => x.IsUsingLoyaltyPoint).Sum(x => x.LoyaltyPoints)}\r\n" +
                   $"total-cost-of-flight: {_flightDetails.Passengers.Sum(x => TotalBookingPrice(x.FirstName))}\r\n" +
                   $"total-unadjusted-ticket-revenue: {_flightDetails.Passengers.Count * _airFlightCost}\r\n" +
                   $"total-adjusted-revenue: {_flightDetails.Passengers.Sum(x => TotalBookingPrice(x.FirstName))}\r\n" +
                   $"can-flight-proceed: {CanDepart()}\r\n";
        }

        private void GrantAccessToPassengersIntoPlane(IEnumerable<PassengerDetails> passengers)
        {
            if (_flightDetails.AirPlaneDetails == null)
                return;
            var airplaneCount = _flightDetails.AirPlaneDetails.NumberOfSeats;

            passengers.Take(airplaneCount).ToList()
                .ForEach(p => { p.CanBoardFlight = true; });
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