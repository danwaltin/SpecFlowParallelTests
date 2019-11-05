Feature: CalculatorTrigonometry

Scenario: Sinus
	When calculating sin for 90 degrees

	Then the result should be 1

Scenario: Cosinus
	When calculating cos for 90 degrees

	Then the result should be 0