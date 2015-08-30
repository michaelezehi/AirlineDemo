using System.Linq;
using Airline.Domain;
using Airline.Services.Implementation;
using Airline.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Airline.Specs.CapacityCalculation
{
    [Binding]
    public sealed class PlaneCapacity
    {
        private readonly IFlightBookingService _flightBookingService;
        private FlightDetails _flightDetails;
        private PassengerDetails _passengerUnderTest;

        public PlaneCapacity()
        {
            _flightBookingService = new FlightBookingService();
        }

        [Given(@"passengers  with details")]
        public void GivenPassengersWithDetails(Table table)
        {
            var passengers = table.CreateSet<PassengerDetails>().ToList();
            _flightDetails.Passengers = passengers;
        }

        [Given(@"flight with details")]
        public void GivenFlightWithDetails(Table table)
        {
            var flightDetails = table.CreateInstance<FlightDetails>();
            _flightDetails = flightDetails;
        }

        [Given(@"airplane details")]
        public void GivenAirplaneDetails(Table table)
        {
            var airPlaneDetails = table.CreateInstance<AirPlaneDetails>();
            _flightDetails.AirPlaneDetails = airPlaneDetails;
        }

        [When(@"all booking is complete")]
        public void WhenTheBookingIsComplete()
        {
            _flightBookingService.BookFlight(_flightDetails);
        }

        [Then(@"the airline cannot depart because of insufficient capacity")]
        public void ThenTheAirlineCannotDepartBecauseOfInsufficientCapacity()
        {
            var hasCapacityToProceed = _flightBookingService.CanDepart();

            Assert.IsFalse(hasCapacityToProceed);
        }

        [Then(@"the airline can depart to it's destination")]
        public void ThenTheAirlineCanDepartToItSDestination()
        {
            var hasCapacityToProceed = _flightBookingService.CanDepart();

            Assert.IsTrue(hasCapacityToProceed);
        }

        [Then(@"the airline expected revenue should be (.*)")]
        public void ThenTheAirlineExpectedRevenueShouldBe(decimal totalCost)
        {
            var flightTotalCost = _flightBookingService.TotalFlightRevenue;

            Assert.AreEqual(totalCost, flightTotalCost);
        }



        [When(@"'(.*)' books his flight")]
        public void WhenTriesToBookHisFlight(string passengerName)
        {
            _passengerUnderTest = _flightDetails.Passengers.FirstOrDefault(x => x.FirstName == passengerName);
            _flightBookingService.BookFlight(_flightDetails);
        }

        [Then(@"he is denied access to the flight")]
        public void ThenHeIsDeniedAccessToTheFlight()
        {
            var passengerAfterFlightIsBooked = _flightDetails.Passengers.First(x => x.FirstName == _passengerUnderTest.FirstName);
            Assert.AreEqual(_passengerUnderTest.CanBoardFlight, passengerAfterFlightIsBooked.CanBoardFlight);

            const int expectedPassengersDenialedAccessCount = 1;
            var expectedCount = _flightDetails.Passengers.Count(x => !x.CanBoardFlight);
            Assert.AreEqual(expectedPassengersDenialedAccessCount, expectedCount);
        }
    }

}
