using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcLibrary;

namespace CalcLibraryTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AdditionTest()
        {
            //Arrange
            SimpleCalculator calc = new SimpleCalculator();

            //Act
            double result = calc.Addition(1.0f,2.0f);

            //Assert
            Assert.AreEqual(3.0,result);
        }

        [TestMethod]
        public void SubstractionTest()
        {
            //Arrange
            SimpleCalculator calc = new SimpleCalculator();

            //Act
            double result = calc.Subtraction(4.0f, 2.0f);

            //Assert
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            //Arrange
            SimpleCalculator calc = new SimpleCalculator();

            //Act
            double result = calc.Multiplication(3.0f,4.0f);

            //Assert
            Assert.AreEqual(12.0,result);
        }
    }
}
