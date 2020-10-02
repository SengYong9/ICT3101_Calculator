using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class SSIfeatureSteps
    {
        private readonly SharedData sharedData;
        public SSIfeatureSteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I entered ""(.*)"" and ""(.*)"" into the calculator and press SSI")]
        public void WhenIEnteredAndIntoTheCalculatorAndPressSSI(int p0, int p1)
        {
            sharedData.result = sharedData.calculator.SSI(p0, p1);
        }
       
    }
}
