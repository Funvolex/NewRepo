﻿using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1= 5;
            int y1 = 5;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 10;
            int y2 = 12;
            char sym2 = '@';
            Draw(x2, y2, sym2);

            Console.ReadLine();
        }
        static void Draw(int x,int y,char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
