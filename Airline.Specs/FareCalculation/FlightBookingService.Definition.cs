using System.Linq;
using Airline.Domain;
using Airline.Services.Implementation;
using Airline.Services.Interfaces;
using Airline.Specs.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Airline.Specs.FareCalculation
{
    [Binding]
    public sealed class FlightBooking
    {
        private IFlightBookingService _flightBookingService;
        private PassengerDetails _passengerUnderTest;
        private FlightDetails _flightDetails;


        [Given(@"a passenger '(.*)'")]
        public void GivenAPassenger(string passengerName)
        {
            var passengers = FakeGenerator.GenertatePassengerDetails();
            _passengerUnderTest = passengers.FirstOrDefault(p => p.FirstName == passengerName);
        }


        [Given(@"flight details")]
        public void GivenFlightDetails(Table table)
        {
            _flightDetails = table.CreateInstance<FlightDetails>();
            _flightBookingService = new FlightBookingService(_flightDetails);
        }


        [When(@"(.*) books a flight with (.*) baggage")]
        public void WhenHeBooksAFlight(string passengerName, int baggageQty)
        {
            var passengers = FakeGenerator.GenertatePassengerDetails();

            var passengerUnderTest = passengers.FirstOrDefault(x => x.FirstName == passengerName);
            if (passengerUnderTest != null)
                passengerUnderTest.Baggage = baggageQty;

            foreach (var passenger in passengers)
            {
                _flightBookingService.BookFlight(passenger);
            }
        }

        [Then(@"he does not get any discount on his fares")]
        public void ThenHeDoesNotGetAnyDiscountOnHisFairs()
        {
            var discountTotal = _flightBookingService.GetPassengerDiscount(_passengerUnderTest.FirstName);
            Assert.AreEqual(0, discountTotal);
        }


        [Then(@"he gets a discount on his flight fare \(total cost is TicketBasePrice minus LoyaltyPoints\)")]
        public void ThenHeGetsADiscountOnHisFlightFare()
        {
            var discount = _flightBookingService.GetPassengerDiscount(_passengerUnderTest.FirstName);
            Assert.AreEqual(100, discount);
            var totalCharge = _flightBookingService.TotalBookingPrice(_passengerUnderTest.FirstName);
            Assert.AreEqual(50, totalCharge);
        }


        [Then(@"total cost is TicketBasePrice minus LoyaltyPoints")]
        public void ThenTotalCostIsTicketBasePriceMinusLoyaltyPoints()
        {
            var cost = _flightBookingService.TotalBookingPrice(_passengerUnderTest.FirstName);
            Assert.AreEqual(100, cost);
        }


        [Then(@"he does not gets charged extra baggage fees")]
        public void ThenHeDoesNotGetsChargedExtraBaggageFees()
        {
            var cost = _flightBookingService.TotalBookingPrice(_passengerUnderTest.FirstName);
            Assert.AreEqual(150, cost);
        }


        [Then(@"he  gets charged extra baggage fees")]
        public void ThenHeGetsChargedExtraBaggageFees()
        {
            var cost = _flightBookingService.TotalBookingPrice(_passengerUnderTest.FirstName);
            Assert.AreEqual(225, cost);
        }

        [Then(@"he  does not pay any fare")]
        public void ThenHeDoesNotPayAnyFare()
        {
            var cost = _flightBookingService.TotalBookingPrice(_passengerUnderTest.FirstName);
            Assert.AreEqual(0, cost);
        }


        [Then(@"she  gets charged extra baggage fees excluding entitled allowance")]
        public void ThenSheGetsChargedExtraBaggageFeesExcludingEntitledAllowance()
        {
            var cost = _flightBookingService.TotalBookingPrice(_passengerUnderTest.FirstName);
            Assert.AreEqual(225, cost);
        }


        [Then(@"he  does not get additional charges")]
        public void ThenHeDoesNotGetAdditionalCharges()
        {
            var cost = _flightBookingService.TotalBookingPrice(_passengerUnderTest.FirstName);
            Assert.AreEqual(0, cost);
        }
    }
}
