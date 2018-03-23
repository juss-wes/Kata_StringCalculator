using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorShould
    {
        [TestMethod]
        public void ReturnZeroGivenNoNumbers ()
        {
            // Arrange
            var input = "";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReturnSumGivenOneNumber()
        {
            // Arrange
            var input = "7";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void ReturnSumGivenTwoNumbers()
        {
            // Arrange
            var input = "1\n2";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ReturnSumGivenFiveNumbers()
        {
            // Arrange
            var input = "1,2\n6\n12,3";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void ReturnSumGivenEightNumbers()
        {
            // Arrange
            var input = "4\n1\n8\n2\n7\n3\n0\n2";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void ReturnSumGivenFourNumbersAndACustomDelimiter()
        {
            // Arrange
            var input = "//;\n4\n1,8;5";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void ReturnExceptionGivenNegatives()
        {
            // Arrange
            var input = "-2,1,8,-3";

            // Act
            try
            {
                var result = StringCalculator.Add(input);

                // Failed if got here with no exception
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                // Assert
                Assert.AreEqual("Negatives not allowed: -2,-3", e.Message);
            }
        }

        [TestMethod]
        public void ReturnSumButIgnoreAboveOneThousand()
        {
            // Arrange
            var input = "18,2,2000,1000";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(20, result);
        }
    }
}
