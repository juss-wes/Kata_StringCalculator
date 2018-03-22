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
            var input = "1,2";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ReturnSumGivenFiveNumbers()
        {
            // Arrange
            var input = "1,2,6,12,3";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void ReturnSumGivenEightNumbers()
        {
            // Arrange
            var input = "4,1,8,2,7,3,0,2";

            // Act
            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(27, result);
        }
    }
}
