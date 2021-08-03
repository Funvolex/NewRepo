using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            PointS p1 = new();
            p1.x = 5;
            p1.y = 4;
            p1.sym = '*';
            p1.Draw();

            PointS p2 = new();
            p2.x = 10;
            p2.y = 12;
            p2.sym = '@';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
