using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buildforcheck.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // Arrange
            var t = new Program();

            // Act
            var actual = t.Sum(1, 2); ;

            // Assert
            Assert.AreEqual(actual, 3);
        }


        [TestMethod()]
        public void MinusTest()
        {
            // Arrange
            var t = new Program();

            // Act
            var actual = t.Minus(4, 2); ;

            // Assert
            Assert.AreEqual(actual, 2);
        }
    }
}