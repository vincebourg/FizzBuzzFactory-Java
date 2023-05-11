namespace CSharpFizzBuzz
{
    public class FizzBuzzFactoryTests
    {
        [Fact]
        public void fizzBuzzIter1_returns_1_if_1()
        {
            var result = fizzBuzzIter1(1);
            Assert.Equal("1", result);
        }

        private string fizzBuzzIter1(int v)
        {
            throw new NotImplementedException();
        }
    }
}