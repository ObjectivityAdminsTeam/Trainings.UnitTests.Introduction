namespace AAA.Tests
{
    using System;
    using Moq;
    using TheorySamples.AAA;
    using Xunit;

    public class DateInfoProviderTest
    {
        [Fact]
        public void Given_DateIsIn2016Year_When_GetYear_Then_Return2016()
        {
            // Arrange
            const int expectedYear = 2016;
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(x => x.Now).Returns(
               new DateTime(expectedYear, 10, 1));
            var provider = new DateInfoProvider(dateTimeProviderMock.Object);

            // Act
            int currentYear = provider.Year;

            // Assert
            Assert.Equal(expectedYear, currentYear);
        }

    }
}
