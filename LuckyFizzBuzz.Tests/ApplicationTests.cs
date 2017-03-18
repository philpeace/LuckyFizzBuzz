
using Xunit;

namespace LuckyFizzBuzz.Tests
{
    public class ApplicationTests
    {
        [Fact]
        public void ApplicationConstructorDoesNotReturnNull()
        {
            var actual = new Application();

            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("1", "1")]
        [InlineData("1 2", "1 2")]
        [InlineData("1 2 3", "1 2 fizz")]
        [InlineData("1 2 6 18", "1 2 fizz fizz")]
        [InlineData("1 2 3 4 5", "1 2 fizz 4 buzz")]
        [InlineData("1 2 3 4 5 6 7 8 9 10", "1 2 fizz 4 buzz fizz 7 8 fizz buzz")]
        [InlineData("1 2 15", "1 2 fizzbuzz")]
        [InlineData("1 2 15 18 30", "1 2 fizzbuzz fizz fizzbuzz")]
        [InlineData("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20", "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz")]
        public void ApplicationRunReturnsCorrectValue(string input, string expected)
        {
            var app = new Application();

            var actual = app.Run(input);

            Assert.Equal(expected, actual);
        }
    }
}
