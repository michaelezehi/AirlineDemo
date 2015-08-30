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
		| James     | 44  | Employee      | 0             | 1       | false               | false                        |
		| Amori     | 51  | Loyalty       | 0             | 1       | false               | false                        |
		| Cindy     | 12  | Loyalty       | 0             | 1       | false               | false                        |
		| Amina     | 8   | General       | 0             | 1       | false               | false                        |
		| Lemar     | 39  | General       | 0             | 1       | false               | false                        |

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
		| James     | 44  | Employee      | 0             | 1       | false               | false                        |
		| Amori     | 51  | Loyalty       | 0             | 1       | false               | false                        |
		| Cindy     | 12  | Loyalty       | 0             | 1       | false               | false                        |
		| Amina     | 8   | General       | 0             | 1       | false               | false                        |
		| Lemar     | 39  | General       | 0             | 1       | false               | false                        |
		| George    | 18  | General       | 0             | 1       | false               | false                        |
		| Jude      | 78  | General       | 0             | 1       | false               | false                        |
And airplane details
		| Name            | NumberOfSeats |
		| Gulfstream-G550 | 8             |

When all booking is complete
Then the airline can depart to it's destination

