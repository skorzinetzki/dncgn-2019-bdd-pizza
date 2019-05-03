Feature: pizza-change-delivery-address
	As a customer
	I want to change the delivery address after ordering a pizza when not picked up yet
	so I can recover from delivering to wrong address

Scenario: Pizza waiting for pickup, changing delivery address should be accepted
	Given "Peter" orders some pizza to "home" address
	And the pizza is waiting for pickup
	When the customer wants to change the delivery address to "work"
	Then the system should accept the change

Scenario: Pizza already picked up, changing delivery address should be denied
	Given "Tim" orders some pizza to "home" address
	And the pizza is picked up by the driver
	When the customer wants to change the delivery address to "work"
	Then the system should deny the change with message "Already picked up"
