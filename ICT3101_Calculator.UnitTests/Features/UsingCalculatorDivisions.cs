using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    class UsingCalculatorDivisions
    {
        private readonly SharedData sharedData;
        public UsingCalculatorDivisions(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.IsTrue(double.IsInfinity(sharedData.result));
        }


        [Then(@"the availability result should ""(.*)""")]
        public void ThenTheAvailabilityResultShould(Decimal p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }

        [Then(@"the factorial should be ""(.*)""")]
        public void ThenTheFactorialShouldBe(int p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }

        [Then(@"the zero factorial result should be ""(.*)""")]
        public void ThenTheZeroFactorialResultShouldBe(int p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }

        [Then(@"the basic reliability result should be ""(.*)""")]
        public void ThenTheBasicReliabilityResultShouldBe(int p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }

        [Then(@"the expected basic reliability result should be ""(.*)""")]
        public void ThenTheExpectedBasicReliabilityResultShouldBe(int p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }

        [Then(@"the density defect result should be (.*)")]
        public void ThenTheDensityDefectResultShouldBe(Decimal p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }

        [Then(@"the SSI result should be ""(.*)""")]
        public void ThenTheSSIResultShouldBe(int p0)
        {
            Assert.That(sharedData.result, Is.EqualTo(p0));
        }
    }
}
