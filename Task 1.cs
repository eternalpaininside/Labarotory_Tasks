using System;

class Program
{
    static void Main(string[] args)
    {
    		int m, n, r1;
    		bool r2, r3, isConvert;
    		double x, r4;
    		do
    		{
        		Console.Write("n ? ");
        		string buf = Console.ReadLine();
        		isConvert = int.TryParse(buf, out n);
        		if (isConvert == false)
            		Console.WriteLine("Ошибка ввода n!");
   			} while (isConvert == false);

    		do
    		{
        		Console.Write("m ? ");
        		string buf = Console.ReadLine();
        		isConvert = int.TryParse(buf, out m);
        		if (isConvert == false)
            		Console.WriteLine("Ошибка ввода m!");
    		} while (isConvert == false);

    		do
    		{
        		Console.Write("x ? ");
        		string buf = Console.ReadLine();
        		isConvert = double.TryParse(buf, out x);
        		if (isConvert == false)
            		Console.WriteLine("Ошибка ввода x!");
        		if (-1.7976931348623157E+308 > x || x > 1.7976931348623157E+308)
            		Console.WriteLine("Число слишком большое/малое для вычисления!");
    		} while (isConvert == false);

    		r1 = n++ + m;
    		if (n < Math.Pow(-2, 31) || n > Math.Pow(2, 31) - 1)
        		Console.WriteLine("Значение n вышло за границы заданного типа!");
    		if (m < Math.Pow(-2, 31) || m > Math.Pow(2, 31) - 1)
        		Console.WriteLine("Значение m вышло за границы заданного типа!");
    		Console.WriteLine($"n = {n}, m = {m}, n++ + m = {r1}");
    		if (r1 < Math.Pow(-2, 31) || r1 > Math.Pow(2, 31) - 1)
        		Console.WriteLine("Невозможно вычислить сумму в заданном типе!");

    		r2 = m-- > n;
    		if (r1 <= Math.Pow(-2, 31) || r1 >= Math.Pow(2, 31) - 1)
        		Console.WriteLine("Невозможно вычислить произведение в заданном типе!");

    		if (n < Math.Pow(-2, 31) || n > Math.Pow(2, 31) - 1)
        		Console.WriteLine("Значение n вышло за границы заданного типа!");
    		if (m < Math.Pow(-2, 31) || m > Math.Pow(2, 31) - 1)
        		Console.WriteLine("Значение m вышло за границы заданного типа!");
    		Console.WriteLine($"n = {n}, m = {m}, m-- > n = {r2}");

    		r3 = n-- > m;
    		if (n < Math.Pow(-2, 31) || n > Math.Pow(2, 31) - 1)
        		Console.WriteLine("Значение n вышло за границы заданного типа!");
    		if (m < Math.Pow(-2, 31) || m > Math.Pow(2, 31) - 1)
        		Console.WriteLine("Значение m вышло за границы заданного типа!");
    		Console.WriteLine($"n = {n}, m = {m}, n-- > m = {r3}");


			if ( x == 1 || x == -1)
            	Console.WriteLine("Нельзя вычислить!");
    		else
            {
    			r4 = Math.Sin(x) + Math.Pow(x, 3) + 1 / (Math.Pow(x, 2) + 1);
    			Console.WriteLine($"x = {x}, sin(x) + x^3 + 1/(x^2 - 1) = {r4}");
            }
		}
}
