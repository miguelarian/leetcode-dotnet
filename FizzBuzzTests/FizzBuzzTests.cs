namespace FizzBuzzTests
{
    using FizzBuzz;

    using System;
    using System.Collections.Generic;

    using Xunit;

    public class FizzBuzzTests : IDisposable
    {
        private FizzBuzz fizzBuzz;

        public FizzBuzzTests()
        {
            this.fizzBuzz = new FizzBuzz();
        }

        public void Dispose()
        {
            this.fizzBuzz = null;
        }

        [Theory]
        [InlineData(0, new string[] {})]
        [InlineData(10001, new string[] { })]
        [InlineData(3, new string[] { "1", "2", "Fizz" })]
        [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void FizzBuzz_Theory(int n, string[] expected)
        {
            // Arrange
            // FizzBuzz fizzBuzz = new FizzBuzz(); // done in constructor

            // Act
            IList<string> result = this.fizzBuzz.Run(n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
