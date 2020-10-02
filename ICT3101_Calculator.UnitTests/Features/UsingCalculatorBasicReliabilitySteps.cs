using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private readonly SharedData sharedData;
        public UsingCalculatorBasicReliabilitySteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press BasicReliability")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressBasicReliability(int p0, int p1, int p2)
        {
            sharedData.result = sharedData.calculator.BasicReliability(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press ExpectedBasicReliability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressExpectedBasicReliability(int p0, int p1, int p2)
        {
            sharedData.result = sharedData.calculator.ExpectedBasicReliability(p0, p1, p2);
        }
       
    }
}
