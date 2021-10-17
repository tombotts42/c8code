using System;
using Xunit;
using Packt;

namespace CalcLibTests
{
    public class CalcTests
    {
        [Fact]
        public void test2and2()
        {
            double a = 2;
            double b = 2;
            double expected = 4;

            var calc = new Calc();

            double actual = calc.Add(a, b);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void test2and3()
        {
        //Given
        double a = 2;
        double b = 3;
        double expected = 5;
        //When

        var calc = new Calc();
        double actual = calc.Add(a, b);       

        //Then
        Assert.Equal(expected, actual);
        }
    }
}
