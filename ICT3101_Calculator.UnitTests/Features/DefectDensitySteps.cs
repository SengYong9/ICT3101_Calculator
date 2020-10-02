using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class DefectDensitySteps
    {
        private readonly SharedData sharedData;
        public DefectDensitySteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I entered ""(.*)"" and ""(.*)"" into the calculator and press Density Defect")]
        public void WhenIEnteredAndIntoTheCalculatorAndPressDensityDefect(int p0, int p1)
        {
            sharedData.result = sharedData.calculator.DensityDefect(p0, p1);
        }
       
    }
}
