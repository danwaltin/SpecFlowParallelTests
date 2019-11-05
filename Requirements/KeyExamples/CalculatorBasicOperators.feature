Feature: Calculator Basic Operators

Scenario: Add two numbers
	When adding 17 and 47

	Then the result should be 64

Scenario: Subtracting two numbers
	When subtracting 17 from 47

	Then the result should be 30

Scenario: Multiplying two numbers
	When multiplying 2 and 8

	Then the result should be 16

Scenario: Dividing two numbers
	When dividing 24 with 3

	Then the result should be 8
