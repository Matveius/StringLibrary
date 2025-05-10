using StringLibrary;

namespace StringLibrary.Tests
{
    public class TextProcessorTests
    {
        [Fact]
        public void ReverseString_ValidInput_ReturnsReversed()
        {
            Assert.Equal("cba", TextProcessor.ReverseString("abc"));
            Assert.Equal("54321", TextProcessor.ReverseString("12345"));
        }

        [Fact]
        public void ReverseString_Empty_ReturnsEmpty()
        {
            Assert.Equal("", TextProcessor.ReverseString(""));
            Assert.Equal(null, TextProcessor.ReverseString(null));
        }

        [Theory]
        [InlineData("hello", 2)]
        [InlineData("WORLD", 1)]
        [InlineData("TEST", 1)]
        public void CountVowels_ValidInput_ReturnsCorrectCount(string input, int expected)
        {
            Assert.Equal(expected, TextProcessor.CountVowels(input));
        }
    }
}