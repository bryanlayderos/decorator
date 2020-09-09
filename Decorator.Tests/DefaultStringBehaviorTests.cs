namespace Decorator.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class DefaultStringBehaviorTests
    {
        private readonly string sampleString = "ABCD";
        private readonly string expectedReversedString = "DCBA";
        private readonly Mock<ILogger> debugLoggerMock = new Mock<ILogger>();

        [TestMethod]
        public void Should_Log_AppendedExpectedString()
        {
            // Arrange
            string resultString;
            var stringBehavior = new LoggingBehavior(new AppendingBehavior(new DefaultStringBehavior()), this.debugLoggerMock.Object);

            // Act
            resultString = stringBehavior.Reverse(this.sampleString);
            Console.WriteLine(resultString);

            // Assert
            this.debugLoggerMock.Verify(x => x.Log(resultString));
        }

        [TestMethod]
        public void Should_Reverse_SampleString()
        {
            // Arrange
            string resultString;
            var stringBehavior = new DefaultStringBehavior();

            // Act
            resultString = stringBehavior.Reverse(this.sampleString);

            // Assert
            Assert.AreEqual(this.expectedReversedString, resultString);
        }
    }
}