Feature: FlightBookingService
	In order to book a flight
	I have to be a specific type of passenger the airline caters for
	1. General – normal fare paying passengers 
	2. Loyalty Members – repeat customers who get benefits for choosing to fly with the airline
	3. Airline Employee – employees of the airline who fly with the airline on a free basis as a perk

@test
Scenario: The Airline charges a base price for a specific route for a standard passenger
Given flight details
		| Origin | Destination | TicketBasePrice | PassengerCost | PlaneCapacity |
		| London | Dublin      | 150             | 100           | 100           |
And a passenger 'Tom'
When Tom books a flight with 1 baggage
Then he does not get any discount on his fares


Scenario: A loyalty passenger gets a discount on their flights when they use their loyalty points
Given flight details
		| Origin | Destination | TicketBasePrice | PassengerCost | PlaneCapacity |
		| London | Dublin      | 150             | 100           | 100           |
And a passenger 'Suzy'
When Suzy books a flight with 1 baggage
Then he gets a discount on his flight fare (total cost is TicketBasePrice minus LoyaltyPoints)


Scenario: A Loyalty member with two bagages and using their extra backage benefits
Given flight details
		| Origin | Destination | TicketBasePrice | PassengerCost | PlaneCapacity |
		| London | Dublin      | 150             | 100           | 100           |
And  a passenger 'Jone'
When Jone books a flight with 2 baggage
Then he does not gets charged extra baggage fees


Scenario: A General member with two baggage
Given flight details
		| Origin | Destination | TicketBasePrice | PassengerCost | PlaneCapacity |
		| London | Dublin      | 150             | 100           | 100           |
And a passenger 'Jack'
When Jack books a flight with 2 baggage
Then he  gets charged extra baggage fees

Scenario: An Airline employee with one baggage
Given flight details
		| Origin | Destination | TicketBasePrice | PassengerCost | PlaneCapacity |
		| London | Dublin      | 150             | 100           | 100           |
And a passenger 'Trevor'
When Trevor books a flight with 1 baggage
Then he  does not pay any fare

Scenario: A Loyalty member with more than 2 baggage
Given flight details
		| Origin | Destination | TicketBasePrice | PassengerCost | PlaneCapacity |
		| London | Dublin      | 150             | 100           | 100           |
And a passenger 'Jone'
When Jone books a flight with 3 baggage
Then she  gets charged extra baggage fees excluding entitled allowance

Scenario: An Employee member with more than 3 baggage
Given flight details
		| Origin | Destination | TicketBasePrice | PassengerCost | PlaneCapacity |
		| London | Dublin      | 150             | 100           | 100           |
And a passenger 'Trevor'
When Trevor books a flight with 3 baggage
Then he  does not get additional charges





