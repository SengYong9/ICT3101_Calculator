using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        private readonly SharedData sharedData;
        public SpecFlowFeature1Steps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            sharedData.result = sharedData.calculator.Add(p0, p1);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }
    }
}
