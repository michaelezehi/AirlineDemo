using System;
using System.Collections.Generic;
using System.Linq;
using Airline.Domain;
using Airline.Domain.enums;
using Airline.Services.Implementation;
using static System.Console;
namespace Airline.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowFlightDetails();
            ShowFlightDetails(5);
            ReadLine();
        }

        private static void ShowFlightDetails(int numberOfPassengersToTake = 8)
        {
            var flightDetails = GenerateFlightDetails();
            var service = new FlightBookingService(flightDetails);
            var passengers = GenertatePassengerDetails().Take(numberOfPassengersToTake).ToList();
            passengers.ForEach(passenger => { service.BookFlight(passenger); });

            WriteLine(service.PrintFlightSummary());
            ConsoleSeparator();
        }

        private static void ConsoleSeparator()
        {
            WriteLine();
            WriteLine("////////////////////////////////////////////////");
            WriteLine();
        }

        private static List<PassengerDetails> GenertatePassengerDetails()
        {
            return new List<PassengerDetails>
            {
                new PassengerDetails {FirstName = "Mark", Age = 35, PassengerType = PassengerType.General, Baggage = 1},
                new PassengerDetails {FirstName = "Tom", Age = 15, PassengerType = PassengerType.General, Baggage = 1},
                new PassengerDetails { FirstName = "James", Age = 72, PassengerType = PassengerType.General,Baggage = 1 },
                new PassengerDetails { FirstName = "Trevor", Age = 54, PassengerType = PassengerType.Employee, Baggage = 1},
                new PassengerDetails { FirstName = "Alan", Age = 65, PassengerType = PassengerType.Loyalty,Baggage = 1,  LoyaltyPoints = 50, IsUsingExtraBaggageAllowance = false, IsUsingLoyaltyPoint = false},
                new PassengerDetails { FirstName = "Suzy", Age = 21, PassengerType = PassengerType.Loyalty,Baggage = 2,  LoyaltyPoints = 40, IsUsingExtraBaggageAllowance = true, IsUsingLoyaltyPoint =false },
                new PassengerDetails { FirstName = "Jone", Age = 56, PassengerType = PassengerType.Loyalty,Baggage = 1, LoyaltyPoints = 100, IsUsingExtraBaggageAllowance = false, IsUsingLoyaltyPoint = true},
                new PassengerDetails { FirstName = "Jack", Age = 50, PassengerType = PassengerType.General,Baggage = 1, }

            };
        }

        private static FlightDetails GenerateFlightDetails()
        {
            return new FlightDetails
            {
                AirPlaneDetails = new AirPlaneDetails { Name = "Gulfstream-G550", NumberOfSeats = 8 },
                Origin = "London",
                Destination = "Dublin",
                PassengerCost = 100,
                TicketBasePrice = 150
            };
        }
    }

}
