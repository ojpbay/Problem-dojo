namespace Problem_Dojo.Tests
{
    public class ReverseIntegerTests
    {
        [Fact]
        public void GivenNegativeSourceShouldReturnNegativeResult()
        {
            var result = ReverseInteger.Reverse(-123);

            Assert.Equal(-321, result);
        }

        [Fact]
        public void Given123ShouldReturn321()
        {
            var result = ReverseInteger.Reverse(123);


            Assert.Equal(321, result);
        }

        [Fact]
        public void Given214748364ShouldReturn463847412()
        {
            var result = ReverseInteger.Reverse(214748364);


            Assert.Equal(463847412, result);
        }

        [Fact]
        public void GivenTrailingZeroInSourceShouldReturnResultWithoutLeadingZero()
        {
            var result = ReverseInteger.Reverse(120);

            Assert.Equal(21, result);
        }

        [Fact]
        public void GivenTrailingZerosInSourceShouldReturnResultWithoutLeadingZeros()
        {
            var result = ReverseInteger.Reverse(3400);

            Assert.Equal(43, result);
        }
    }
}