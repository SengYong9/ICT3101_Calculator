Feature: UsingCalculatorFactorial
	In order to conquer factorial
	As a factorial enthusiast
	I want to understand a variety of fatorial operations

@Factorial
Scenario: Factorial by a number
	Given I have a calculator
	When I have entered "5" into the calculator and press factorial
	Then the factorial should be "120"

@Factorial
Scenario: Factorial by zero
	Given I have a calculator
	When I have entered "0" into the calculator and press zero factorial
	Then the zero factorial result should be "1"