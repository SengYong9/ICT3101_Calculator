Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@BasicReliability
Scenario: Calculating Basic Reliability
	Given I have a calculator
	When I have entered "10" and "50" and "100" into the calculator and press BasicReliability
	Then the basic reliability result should be "5"

@BasicReliability
Scenario: Calculating Expected Basic Reliability
	Given I have a calculator
	When I have entered "100" and "10" and "100" into the calculator and press ExpectedBasicReliability
	Then the expected basic reliability result should be "100"