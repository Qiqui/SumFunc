using SumFunc;

namespace SumFuncTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(new[] { 1, 2, 3 }, 3)]
        [TestCase(new[] { -1, -2, -3 }, -5)]
        [TestCase(new[] { 1, 1, 1 }, 2)]
        [TestCase(new[] { -5, -4, -3, -2 }, -9)]
        public void SumMinNumbers_PositiveCases_ReturnsCorrectSum(int[] input, int expected)
        {
            int result = Calculator.SumMinNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SumMinNumbers_EmptyArray_ThrowsArgumentException()
        {
            int[] emptyArray = Array.Empty<int>();
            Assert.Throws<ArgumentException>(() => Calculator.SumMinNumbers(emptyArray));
        }

        [Test]
        public void SumMinNumbers_NullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Calculator.SumMinNumbers(null));
        }
        [Test]
        public void SumMinNumbers_PositiveOverflow_ThrowsException()
        {
            int[] overflowCase = { int.MaxValue, int.MaxValue };
            Assert.Throws<OverflowException>(() => Calculator.SumMinNumbers(overflowCase));
        }

        [Test]
        public void SumMinNumbers_Overflow_ThrowsException()
        {
            int[] overflowCase = { int.MinValue, int.MinValue };
            Assert.Throws<OverflowException>(() => Calculator.SumMinNumbers(overflowCase));
        }
    }

    [TestFixture]
    public class InputParserTests
    {
        [TestCase("1, 2, 3", new[] { 1, 2, 3 })]
        [TestCase("1 2 3", new[] { 1, 2, 3 })]
        public void ParseInput_ValidFormats_ParsesCorrectly(string input, int[] expected)
        {
            int[] result = InputParser.ParseInput(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ParseInput_InvalidFormat_ThrowsException()
        {
            Assert.Throws<FormatException>(() => InputParser.ParseInput("1,a,3"));
        }

        [Test]
        public void ParseInput_EmptyInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => InputParser.ParseInput(""));
        }
    }
}

