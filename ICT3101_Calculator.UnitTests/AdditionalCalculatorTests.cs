using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("MagicNumber.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }

        [Test]
        public void GenerateMagicNumber_WhenGeneratingMagicNumber_ResultEqualMagicNumber()
        {
            //Act
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            //Assert
            Assert.That(result, Is.EqualTo(84));
        }
    }
}
