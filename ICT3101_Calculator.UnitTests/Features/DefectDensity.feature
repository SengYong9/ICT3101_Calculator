Feature: DefectDensity
	In order to calculate defect density
	As a quality engineers
	I want to be able to use my calculator to do this

@DefectDensity
Scenario: Calculating Defect Density
	Given I have a calculator
	When I entered "36" and "20" into the calculator and press Density Defect
	Then the density defect result should be 1.8