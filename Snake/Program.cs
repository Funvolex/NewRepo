using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            PointS p1 = new(5, 4, '*'); //пример инкапсуляции
            p1.Draw();

            PointS p2 = new(10, 12, '@');
            p2.Draw();

            Console.ReadLine();
        }
    }
}
