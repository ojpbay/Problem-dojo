namespace Problem_Dojo.Tests
{
    public class ReverseIntegerTests
    {        
        [Fact]
        public void GivenSourceShouldReturnSourceReversed()
        {
            var result = ReverseInteger.Reverse(123456);


            Assert.Equal(654321, result);
        }

        [Fact]
        public void GivenSourceWithTrailingZerosShouldReturnResultWithNoLeadingZeros()
        {
            var result = ReverseInteger.Reverse(1200);

            Assert.Equal(21, result);
        }

        [Fact]
        public void GivenNegativeSourceShouldReturnNegativeResult()
        {
            var result = ReverseInteger.Reverse(-123);

            Assert.Equal(-321, result);
        }
    }
}