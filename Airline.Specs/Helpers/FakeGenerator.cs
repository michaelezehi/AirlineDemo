using System.Collections.Generic;
using Airline.Domain;
using Airline.Domain.enums;

namespace Airline.Specs.Helpers
{
    public static class FakeGenerator
    {
        public static List<PassengerDetails> GenertatePassengerDetails()
        {
            return new List<PassengerDetails>
            {
                new PassengerDetails {FirstName = "Mark", Age = 35, PassengerType = PassengerType.General, },
                new PassengerDetails {FirstName = "Tom", Age = 15, PassengerType = PassengerType.General, },
                new PassengerDetails { FirstName = "James", Age = 72, PassengerType = PassengerType.General, },
                new PassengerDetails { FirstName = "Trevor", Age = 54, PassengerType = PassengerType.Employee, },
                new PassengerDetails { FirstName = "Alan", Age = 65, PassengerType = PassengerType.Loyalty,  LoyaltyPoints = 50, IsUsingExtraBaggageAllowance = false, IsUsingLoyaltyPoint = false},
                new PassengerDetails { FirstName = "Suzy", Age = 21, PassengerType = PassengerType.Loyalty,  LoyaltyPoints = 40, IsUsingExtraBaggageAllowance = true, IsUsingLoyaltyPoint =false },
                new PassengerDetails { FirstName = "Jone", Age = 56, PassengerType = PassengerType.Loyalty, LoyaltyPoints = 100, IsUsingExtraBaggageAllowance = false, IsUsingLoyaltyPoint = true},
                new PassengerDetails { FirstName = "Jack", Age = 50, PassengerType = PassengerType.General, }

            };
        }
    }
}
