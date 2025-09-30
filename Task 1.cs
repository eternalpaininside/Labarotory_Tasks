using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            // ввод исходных данных
            int m, n, r1;
            bool r2, r3, isConvert;
            double x, r4;
            {
                Console.WriteLine("Введите целое число n:");
                string buf = Console.ReadLine();
                isConvert = int.TryParse(buf, out n);
                if (isConvert == false)
                    Console.WriteLine("Ошибка при вводе целого числа n! Введите n еще раз:");
            } while (isConvert == false) ;

            do
            {
                Console.WriteLine("Введите целое число m:");
                string buf = Console.ReadLine();
                isConvert = int.TryParse(buf, out m);
                if (isConvert == false)
                    Console.WriteLine("Ошибка при вводе целого числа m! Введите m еще раз:");
            } while (isConvert == false);

            do
            {
                Console.WriteLine("Введите вещественное число x: ");
                string buf = Console.ReadLine();
                isConvert = double.TryParse(buf, out x);
                if (isConvert == false)
                    Console.WriteLine("Ошибка при вводе вещественного числа x! Введите x еще раз:");
            } while (isConvert == false);

            // вычисления
            r1 = n++ + m;
            Console.WriteLine($"n++ +m={r1}, m={m}, n={n}");
            r2 = m-- > n;
            Console.WriteLine($"m-- >n={r2}, m={m}, n={n}");
            r3 = n-- > m;
            Console.WriteLine($"n-- >m={r3}, m={m}, n={n}");

            if (x == 1 || x == -1)
                Console.WriteLine("Ошибка: деление на 0");
            else
            {
                r4 = Math.Sin(x) + Math.Pow(x, 3) + 1 / (Math.Pow(x, 2) - 1);
                Console.WriteLine($"sin(x) + x^3 + 1/(x^2 - 1) = {r4}, x={x}");
            }
        }
    }
}
