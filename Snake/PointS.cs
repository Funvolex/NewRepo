using System;

namespace Snake
{
    class PointS
    {
        public int x;
        public int y;
        public char sym;

        public PointS(int inx, int iny, char insym) //это конструктор
        {
            x = inx;
            y = iny;
            sym = insym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }

}
