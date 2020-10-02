using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private readonly SharedData sharedData;
        public UsingCalculatorDivisionsSteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            sharedData.result = sharedData.calculator.Divide(p0, p1);
        }
    }
}
