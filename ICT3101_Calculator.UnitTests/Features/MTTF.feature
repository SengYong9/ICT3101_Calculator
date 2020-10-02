Feature: MTTF
	In order to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered "10" and "40" into the calculator and press MTBF
	Then the availability result should "50"

@Availability
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered "100" and "160" into the calculator and press Availability
	Then the availability result should "62.5"