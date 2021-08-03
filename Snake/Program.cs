using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int y1 = 5;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 10;
            int y2 = 12;
            char sym2 = '@';
            Draw(x2, y2, sym2);

            /*PointS p1 = new PointS();
          
            p1.x = 5;
            p1.y = 5;
            p1.sym = '*';

            PointS p2 = new PointS();
            p2.x = 10; p2.y = 10; p2.sym = '@';

            p1.Draw();
            p2.Draw();*/

            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
