
using ICT3101_Calculator;
using NUnit.Framework;
using System;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToProduct()
        {
            //Act 
            double result = _calculator.Multiply(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }
        [Test]
        public void Divide_WhenDivideTwoNumbers_ResultEqualToDivide()
        {
            //Act
            double result = _calculator.Divide(20, 10);
            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        //[Test]
        //public void Divide_WithNegativeInputs_ResultThrowArgumentException()
        //{
        //    Assert.That(() => _calculator.Divide (0,0),Throws
        //        .ArgumentException);
        //}

        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithZeroAsInputs_ResultThrowArgumentException(int a, int b)
        //{
        //    Assert.That(() => _calculator.Divide(a, b), Throws
        //       .ArgumentException);
        //}

        [Test]
        [TestCase(-1)]
        public void Factorial_WhenCalculatingFactorial_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws
               .ArgumentException);
        }

        [Test]
        public void Factorial_WhenCalculatingFactorial_ResultEqualToFactorial()
        {
            //Act
            double result = _calculator.Factorial(6);
            //Assert
            Assert.That(result, Is.EqualTo(720));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(-2, 8)]
        [TestCase(0, 8)]
        [TestCase(8, 0)]
        public void AreaOfTriangle_WhenCalculatingAreaOfTriangle_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.AreaOfTriangle(a,b), Throws
                           .ArgumentException);
        }

        [Test]
        public void AreaOfTriangle_WhenCalculatingAreaOfTriangle_ResultEqualToAreaOfTriangle()
        {
            //Act
            double result = _calculator.AreaOfTriangle(5,10);
            //Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void AreaOfCircle_WhenCalculatingAreaOfCircle_ResultThrowArgumentException(int b)
        {
            Assert.That(() => _calculator.AreaOfCircle(b), Throws
                           .ArgumentException);
        }

        [Test]
        public void AreaOfCircle_WhenCalculatingAreaOfCircle_ResultEqualToAreaOfCircle()
        {
            //Act
            double result = _calculator.AreaOfCircle(5);
            //Assert
            Assert.That(result, Is.EqualTo(78.55));
        }

        [Test]
        public void GenerateMagicNumber_WhenGeneratingMagicNumber_ResultEqualMagicNumber()
        {
            IFileReader fileReader = new FileReader();
            //Act
            double result = _calculator.GenMagicNum(4, fileReader);
            //Assert
            Assert.That(result, Is.EqualTo(180));
        }

        //Unknown Unit Test
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5,5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5,4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }


        //Unknown Unit Test

    }
}