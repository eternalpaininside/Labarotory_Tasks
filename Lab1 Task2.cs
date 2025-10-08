using System;

class Program
{
    static void Main(string[] args)
    {
        double x, y;
            bool isInArea, isConvert;
            // ввод координат x и y
            do
            {
                Console.Write("x ? ");
                string buf = Console.ReadLine();
                isConvert = double.TryParse(buf, out x);
                if (isConvert == false)
                    Console.WriteLine("Ошибка ввода x!");
            } while (isConvert == false);

            do
            {
                Console.Write("y ? ");
                string buf = Console.ReadLine();
                isConvert = double.TryParse(buf, out y);
                if (isConvert == false)
                    Console.WriteLine("Ошибка ввода y!");
            } while (isConvert == false);
            // проверка принадлежности точки к заданной области
            isInArea = (5>=x && x>=0) && (1>=y && y>=0);
            Console.WriteLine(isInArea);

    }
}
