using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // вычисления типа данных float
                float a = 1000f, b = 0.0001f;
                float c, d, e, result;
                Console.WriteLine("Вычисления данных типа float:");
                c = (float)Math.Pow(a + b, 2);
                Console.WriteLine($"(a+b)^2 = {c}");
                d = (float)Math.Pow(a, 2) + 2*a*b;
                Console.WriteLine($"a^2 + 2ab = {d}");
                e = (float)Math.Pow(b, 2);
                Console.WriteLine($"b^2 = {e}");
                result = (c - d) / e;
                Console.WriteLine($"((a+b)^2 - (a^2 + 2ab))/b^2 = {result}");
            }
            {
                // вычисления типа данных double
                double a = 1000, b = 0.0001;
                double c, d, e, result;
                Console.WriteLine("Вычисления данных типа double:");
                c = (double)Math.Pow(a + b, 2);
                Console.WriteLine($"(a+b)^2 = {c}");
                d = (double)Math.Pow(a, 2) + 2 * a * b;
                Console.WriteLine($"a^2 + 2ab = {d}");
                e = (double)Math.Pow(b, 2);
                Console.WriteLine($"b^2 = {e}");
                result = (c - d) / e;
                Console.WriteLine($"((a+b)^2 - (a^2 + 2ab))/b^2 = {result}");
            }
        }
    }
}
