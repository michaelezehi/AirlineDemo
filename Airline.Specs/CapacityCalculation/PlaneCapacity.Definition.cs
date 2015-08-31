using System.Collections.Generic;
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
        private IFlightBookingService _flightBookingService;
        private FlightDetails _flightDetails;
        private List<PassengerDetails> _passengers;


        [Given(@"passengers  with details")]
        public void GivenPassengersWithDetails(Table table)
        {
            _passengers = table.CreateSet<PassengerDetails>().ToList();
        }

        [Given(@"flight with details")]
        public void GivenFlightWithDetails(Table table)
        {
            _flightDetails = table.CreateInstance<FlightDetails>();
            _flightBookingService = new FlightBookingService(_flightDetails);
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
            foreach (var passenger in _passengers)
            {
                _flightBookingService.BookFlight(passenger);
            }
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


        [Then(@"'(.*)' is denied access to the flight")]
        public void ThenIsDeniedAccessToTheFlight(string passengerName)
        {
            var passengerAfterFlightIsBooked = _flightDetails.Passengers.First(x => x.FirstName == passengerName);
            Assert.AreEqual(passengerAfterFlightIsBooked.CanBoardFlight, passengerAfterFlightIsBooked.CanBoardFlight);

            const int expectedPassengersDenialedAccessCount = 1;
            var denailedCount = _flightDetails.Passengers.Count(x => !x.CanBoardFlight);
            Assert.AreEqual(expectedPassengersDenialedAccessCount, denailedCount);
        }

        [Then(@"(.*) passengers should have access to the flight")]
        public void ThenPassengersShouldHaveAccessToTheFlight(int expectedAllowedPassengerCount)
        {
            var denailedCount = _flightDetails.Passengers.Count(x => x.CanBoardFlight);
            Assert.AreEqual(expectedAllowedPassengerCount, denailedCount);
        }

    }

}
