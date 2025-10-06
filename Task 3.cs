using System;

class Program
{
    static void Main(string[] args)
    {
     	double a = 1000, b = 0.0001;
     	double c = Math.Pow(a + b, 2);
     	double d = Math.Pow(a, 2);
     	double e = 2 * a * b;
     	double f = Math.Pow(b, 2);
     	double result = (c - (d + e)) / f;
     	Console.WriteLine($"Результат вычисления (double) = {result}");
    
     	float fa = 1000f, fb = 0.0001f;
     	float fc = (float)Math.Pow(fa + fb, 2);
    	float fd = (float)Math.Pow(fa, 2);
    	float fe = 2 * fa * fb;
     	float ff = (float)Math.Pow(fb, 2);
     	float fresult = (fc - (fd + fe)) / ff;
     	Console.WriteLine($"Результат вычисления (float) = {fresult}");
 	}
}


