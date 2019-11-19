using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2.5, 4.6, 0.5, double.Y)]
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
         Var   res = (Math.Pow(a + b), exp)/(1+Math.Log10(a + b * x));
            return res;     
        }

        [Fact]
        public void TestNormalB(
                                 double a,
                                 double b,
                                 double[] x);
        {
            
            var y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                Random rnd = new Random();
                a = rnd.Next(1.2,2.3)
                b = rnd.Next(1.2,2.3)
                y[i] = MyFunction(a, b, x[i]);
            }
            
            Var   res = (Math.Pow((a + b), exp)) / (1 + Math.Log10(a + b * x));
            return res; 
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(1, 1, new double[0]);
            Assert.Empty(res);
        }
    }
}
