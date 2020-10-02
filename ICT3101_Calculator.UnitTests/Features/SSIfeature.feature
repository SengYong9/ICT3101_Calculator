Feature: SSIfeature
	In order to shipped source instruction
	As a quality engineers
	I want to be able to use my calculator to do this

@SSI
Scenario: Calculating SSI
	Given I have a calculator
	When I entered "50" and "10" into the calculator and press SSI
	Then the SSI result should be "60"