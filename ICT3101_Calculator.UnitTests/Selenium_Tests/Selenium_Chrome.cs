using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ICT3101_Calculator.UnitTests
{
    [Parallelizable]
    [TestFixture]
    class Selenium_Chrome
    {
        private string _testURL = "https://www.google.com";
        private IWebDriver _driver;
        [SetUp]
        public void Start_Browser()
        {
            // Setup local Selenium WebDriver
            //_driver = new ChromeDriver(@"C:\Users\User\source\repos\ICT3101_Calculator\ICT3101_Calculator.UnitTests\bin\Debug\netcoreapp2.2");

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            _driver = new ChromeDriver(option);

        }
        [Test]
        public void GoogleAdd_WhenAdding2and2_ResultEquals4()
        {
            //Setup----------------------------/
            _driver.Url = _testURL;
            //System.Threading.Thread.Sleep(1000);
            //Act------------------------------/
            IWebElement searchBox = _driver.FindElement(By.CssSelector("[name = 'q']"));
            searchBox.SendKeys("2 + 2" + Keys.Return);
            //System.Threading.Thread.Sleep(1000);
            //Assert---------------------------/
            IWebElement calcAnswer = _driver.FindElement(By.Id("cwos"));
            Assert.That(calcAnswer.Text, Is.EqualTo("4"));
        }
        [TearDown]
        public void Close_Browser()
        {
            _driver.Quit();
        }
    }
}
