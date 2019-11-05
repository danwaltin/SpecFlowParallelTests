Feature: Calculator Basic Operators

Scenario: Add two numbers
	When adding 17 and 47

	Then the result should be 64

Scenario: Subtracting two numbers
	When subtracting 17 from 47

	Then the result should be 30
