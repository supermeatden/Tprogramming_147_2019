using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2.5, 4.6, 0, double.NaN)]
        [InlineData(1, 1, 2, 2.5)]
        [InlineData(-1, 1, 1, 0)]
        public void TestCalc(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void TestNormalA()
        {
            x = (Math.pow(a + b),2.5)/(1+Math.Log10(a + b * x));
            return x;     
        }

        [Fact]
        public void TestNormalB()
        {
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(1, 1, new double[0]);
            Assert.Empty(res);
        }
    }
}
