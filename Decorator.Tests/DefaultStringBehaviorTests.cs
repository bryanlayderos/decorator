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