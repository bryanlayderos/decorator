namespace Decorator.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class AppendingBehaviorTests
    {
        private readonly string sampleString = "ABCD";
        private readonly string expectedReversedString = "DCBA ABCD";

        [TestMethod]
        public void Should_Append_ReverseString()
        {
            // Arrange
            string resultString;
            var stringBehavior = new AppendingBehavior(new DefaultStringBehavior());

            // Act
            resultString = stringBehavior.Reverse(this.sampleString);

            // Assert
            Assert.AreEqual(this.expectedReversedString, resultString);
        }
    }
}