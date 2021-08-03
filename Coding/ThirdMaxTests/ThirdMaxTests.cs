namespace ThirdMaxTests
{
    using System;

    using ThirdMax;

    using Xunit;

    public class ThirdMaxTests : IDisposable
    {
        private ThirdMax sut;

        public ThirdMaxTests()
        {
            this.sut = new ThirdMax();
        }

        [Fact]
        public void ThirdMax_EmptyArray_Zero()
        {
            // Arrange
            ThirdMax sut = new ThirdMax();
            int[] numbers = new int[0];

            // Act
            int result = sut.GetThirdMax(numbers);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void ThirdMax_SingleItemArray_SingleItem()
        {
            // Arrange
            ThirdMax sut = new ThirdMax();
            int[] numbers = new int[1] { 1 };

            // Act
            int result = sut.GetThirdMax(numbers);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void ThirdMax_ThreeItemsArray_ThirdMax()
        {
            // Arrange
            ThirdMax sut = new ThirdMax();
            int[] numbers = new int[] { 3, 2, 1 };

            // Act
            int result = sut.GetThirdMax(numbers);

            // Assert
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(new int[3] { 1 ,2, 3}, 1)]
        [InlineData(new int[3] { 1, 1, 2 }, 2)]
        [InlineData(new int[2] { 1, 2 }, 2)]
        [InlineData(new int[5] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[4] { 2, 2, 3, 1 }, 1)]
        public void ThirdMax_NumbersArray_ThirdMax(int[] numbers, int expected)
        {
            // Arrange
            ThirdMax sut = new ThirdMax();

            // Act
            int result = this.sut.GetThirdMax(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        public void Dispose()
        {
            this.sut = null;
        }
    }
}
