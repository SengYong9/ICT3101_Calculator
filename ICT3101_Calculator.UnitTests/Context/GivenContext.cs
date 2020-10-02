using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    public class SharedData
    {
        public double result;
        public Calculator calculator;
    }
    [Binding]
    class GivenContext
    {
        private readonly SharedData sharedData;
        
        public GivenContext(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            sharedData.calculator = new Calculator();
        }
    }
}
