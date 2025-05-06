namespace SumFuncTests
{
    public class Tests
    {

        [Test]
        public void SumMinNumbers_EmptyArray_ThrowsArgumentException()
        {
            int[] emptyArray = Array.Empty<int>();
            Assert.Throws<ArgumentException>(() => Program.SumMinNumbers(emptyArray));
        }

        [Test]
        public void SumMinNumbers_NegativeNumbers_ReturnsCorrectSum()
        {
            int[] numbers = { -5, -4, -3, -2 };
            int result = Program.SumMinNumbers(numbers);
            Assert.That(result, Is.EqualTo(-9));
        }

        [Test]
        public void SumMinNumbers_NullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Program.SumMinNumbers(null));
        }
    }
}
