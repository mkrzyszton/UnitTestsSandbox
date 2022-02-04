using Xunit;

namespace DemoConsoleApp.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(2, 2, 4)]
        [InlineData(6, 5, 11)]
        [InlineData(10, 5, 15)]
        [InlineData(1, 5, 6)]
        [InlineData(5, 5, 10)]
        public void Calculator_AddMethod_ValueClassification(int a, int b, int result)
        {
            //arrange

            Calculator calc = new Calculator();

            //act

            int method = calc.Add(a, b);

            //int addMethodResult = calc.Add(5, 5);

            //assert

            Assert.Equal(result, method);
        }
    }
}