Feature: PlaneCapacity
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@test
Scenario: An airplane with less than expected capacity (Min capacity 75%)
Given flight with details
		| Origin | Destination | TicketBasePrice | PassengerCost |
		| London | Dublin      | 150             | 100           |
And  passengers  with details
		| FirstName | Age | PassengerType | LoyaltyPoints | Baggage | IsUsingLoyaltyPoint | IsUsingExtraBaggageAllowance |
		| Mark      | 35  | General       | 0             | 1       | false               | false                        |
		| Tom       | 15  | General       | 0             | 1       | false               | false                        |
		| James     | 72  | General       | 0             | 1       | false               | false                        |
		| Trevor    | 54  | Employee      | 0             | 1       | false               | false                        |
		| Alan      | 65  | Loyalty       | 50            | 1       | false               | false                        |

And airplane details
		| Name            | NumberOfSeats |
		| Gulfstream-G550 | 8             |

When all booking is complete
Then the airline cannot depart because of insufficient capacity


Scenario: An airplane with expected capacity (Min capacity 75%)
Given flight with details
		| Origin | Destination | TicketBasePrice | PassengerCost |
		| London | Dublin      | 150             | 100           |
And  passengers  with details
		| FirstName | Age | PassengerType | LoyaltyPoints | Baggage | IsUsingLoyaltyPoint | IsUsingExtraBaggageAllowance |
		| Mark      | 35  | General       | 0             | 1       | false               | false                        |
		| Tom       | 15  | General       | 0             | 1       | false               | false                        |
		| James     | 72  | General       | 0             | 1       | false               | false                        |
		| Trevor    | 54  | Employee      | 0             | 1       | false               | false                        |
		| Alan      | 65  | Loyalty       | 50            | 1       | false               | false                        |
		| Suzy      | 21  | Loyalty       | 40            | 2       | false               | true                         |
		| Jone      | 56  | Loyalty       | 100           | 1       | true                | false                        |
And airplane details
		| Name            | NumberOfSeats |
		| Gulfstream-G550 | 8             |

When all booking is complete
Then the airline can depart to it's destination


Scenario: An airplane with expected capacity and total adjusted revenue
Given flight with details
		| Origin | Destination | TicketBasePrice | PassengerCost |
		| London | Dublin      | 150             | 100           |
And  passengers  with details
		| FirstName | Age | PassengerType | LoyaltyPoints | Baggage | IsUsingLoyaltyPoint | IsUsingExtraBaggageAllowance |
		| Mark      | 35  | General       | 0             | 1       | false               | false                        |
		| Tom       | 15  | General       | 0             | 1       | false               | false                        |
		| James     | 72  | General       | 0             | 1       | false               | false                        |
		| Trevor    | 54  | Employee      | 0             | 1       | false               | false                        |
		| Alan      | 65  | Loyalty       | 50            | 1       | false               | false                        |
		| Suzy      | 21  | Loyalty       | 40            | 2       | false               | true                         |
		| Jone      | 56  | Loyalty       | 100           | 1       | true                | false                        |
		| Jack      | 50  | General       | 0             | 1       | false               | false                        |
And airplane details
		| Name            | NumberOfSeats |
		| Gulfstream-G550 | 8             |

When all booking is complete
Then the airline expected revenue should be 950



Scenario: An airplane with expected capacity (8) should exceed the total cost of the flight
Given flight with details
		| Origin | Destination | TicketBasePrice | PassengerCost |
		| London | Dublin      | 150             | 100           |
And  passengers  with details
		| FirstName | Age | PassengerType | LoyaltyPoints | Baggage | IsUsingLoyaltyPoint | IsUsingExtraBaggageAllowance |
		| Mark      | 35  | General       | 0             | 1       | false               | false                        |
		| Tom       | 15  | General       | 0             | 1       | false               | false                        |
		| James     | 72  | General       | 0             | 1       | false               | false                        |
		| Trevor    | 54  | Employee      | 0             | 1       | false               | false                        |
		| Alan      | 65  | Loyalty       | 50            | 1       | false               | false                        |
		| Suzy      | 21  | Loyalty       | 40            | 2       | false               | true                         |
		| Jone      | 56  | Loyalty       | 100           | 1       | true                | false                        |
		| Jack      | 50  | General       | 0             | 1       | false               | false                        |
And airplane details
		| Name            | NumberOfSeats |
		| Gulfstream-G550 | 8             |

When all booking is complete
Then the adjusted revenue should exceed airline total cost of 800 


Scenario: An additional passenger Joe tries to book after the plane capacity is reached
Given flight with details
		| Origin | Destination | TicketBasePrice | PassengerCost |
		| London | Dublin      | 150             | 100           |
And  passengers  with details
		| FirstName | Age | PassengerType | LoyaltyPoints | Baggage | IsUsingLoyaltyPoint | IsUsingExtraBaggageAllowance | 
		| Mark      | 35  | General       | 0             | 1       | false               | false                        | 
		| Tom       | 15  | General       | 0             | 1       | false               | false                        | 
		| James     | 72  | General       | 0             | 1       | false               | false                        | 
		| Trevor    | 54  | Employee      | 0             | 1       | false               | false                        | 
		| Alan      | 65  | Loyalty       | 50            | 1       | false               | false                        | 
		| Suzy      | 21  | Loyalty       | 40            | 2       | false               | true                         | 
		| Jone      | 56  | Loyalty       | 100           | 1       | true                | false                        | 
		| Jack      | 50  | General       | 0             | 1       | false               | false                        | 
		| Joe       | 18  | General       | 0             | 1       | false               | false                        | 
And airplane details
		| Name            | NumberOfSeats |
		| Gulfstream-G550 | 8             |

When all booking is complete
Then 'Joe' is denied access to the flight
And 8 passengers should have access to the flight