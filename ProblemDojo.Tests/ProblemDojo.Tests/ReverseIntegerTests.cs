namespace ProblemDojo.Tests
{
    public class ReverseIntegerTests
    {
        [Fact]
        public void NegativeSourceShouldBeNegativeResult()
        {
            var result = ReverseInteger.Reverse(-123);

            Assert.Equal(-321, result);
        }

        [Fact]
        public void IntegerShouldBeReversed()
        {
            var result = ReverseInteger.Reverse(123);

            Assert.Equal(321, result);
        }

        [Fact]
        public void TrailingZeroShouldBeRemovedFromResult()
        {
            var result = ReverseInteger.Reverse(120);

            Assert.Equal(21, result);
        }
    }
}