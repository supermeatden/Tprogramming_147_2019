using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var c = (Math.pow(a + b),2.5)/(1+Math.Log10(a + b * x));
            return c;
        }

        public static double[] TaskA (
                                     double a,
                                     double b,
                                     double xn,
                                     double xk,
                                     double dx)
        {
            var steps = (int)Math.Floor((xk - xn) / dx);
            var y = new double[steps];
            var i = 0;
            for (var x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB (
                                 double a,
                                 double b,
                                 double[] x)
        {
            var y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var taskA = TaskA(2.5, 4.6, 1.1, 3.6, 0.5);
            Console.WriteLine(taskA);

            for (var i = 0; i < taskA.Length; i++)
            {
                Console.WriteLine($"y={taskA[i]}");
            }

            var xB = new double[] {1.2 , 1.28, 1.36, 1.46, 2.35 };
            var taskB = TaskB(2, 3, xB);
            for (var i = 0; i < xB.Length; i++)
            {
                Console.WriteLine($"x={xB[i]} y={taskB[i]}");
            }

            var item = new Platypus();
            Console.WriteLine(item.View());

            Console.ReadLine();
        }
    }
}
