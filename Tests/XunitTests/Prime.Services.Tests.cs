using System;
using Xunit;
using Prime.Services;

namespace Prime.Services.Tests
{
    public class PrimeServicesShould
    {
        PrimeService _service;

        public PrimeServicesShould()
        {
            _service = new PrimeService();
        }

        
        [Fact]
        public void ReturnFalseIfInputIsOne()
        {
            var input = 1;
            var result = _service.IsPrime(input);

            Assert.False(result, "1 is not a prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ReturnFalseIfInputLessThan1(int inlineDataValue)
        {
            var result = _service.IsPrime(inlineDataValue);

            Assert.False(result, $"{inlineDataValue} is not a prime");
        }
    }
}
