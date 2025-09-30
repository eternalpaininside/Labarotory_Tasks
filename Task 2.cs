
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool isInArea, isConvert;
            // ввод координат x и y
            do
            {
                Console.WriteLine("Введите координату x:");
                string buf = Console.ReadLine();
                isConvert = double.TryParse(buf, out x);
                if (isConvert == false)
                    Console.WriteLine("Ошибка при вводе координаты x");
            } while (isConvert == false);

            do
            {
                Console.WriteLine("Введите координату y:");
                string buf = Console.ReadLine();
                isConvert = double.TryParse(buf, out y);
                if (isConvert == false)
                    Console.WriteLine("Ошибка при вводе переменной y");
            } while (isConvert == false);
            // проверка принадлежности точки к заданной области
            isInArea = (5>=x && x>=0) && (2>=y && y>=0);
            if (isInArea)
                Console.WriteLine($"Точка ({x};{y}) принадлежит к заданной области");
            else
                Console.WriteLine($"Точка ({x};{y}) не принадлежит к заданной области");
        }
    }
}
