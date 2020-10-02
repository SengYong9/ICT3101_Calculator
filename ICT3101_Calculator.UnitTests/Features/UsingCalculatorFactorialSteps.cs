using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private readonly SharedData sharedData;
        public UsingCalculatorFactorialSteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            sharedData.result = sharedData.calculator.Factorial(p0);
        }
        
        [When(@"I have entered ""(.*)"" into the calculator and press zero factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressZeroFactorial(int p0)
        {
            sharedData.result = sharedData.calculator.Factorial(p0);
        }
       
    }
}
