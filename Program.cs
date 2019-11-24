using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Point
    {
        int x;
        int y;
        char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool i = true;
            while (i == true)
            {
                try
                {
                    Console.WriteLine("Введите координаты");
                    Console.Write("x = ");
                    int x = Convert.ToInt16(Console.ReadLine());
                    Console.Write("y = ");
                    int y = Convert.ToInt16(Console.ReadLine());
                    if (x >= 0 & y >= 0)
                        i = false;
                    Console.Clear();
                    HorizontalLine h1 = new HorizontalLine(x, x + 20, y, '*');
                    h1.Draw();
                    HorizontalLine h2 = new HorizontalLine(x, x + 20, y + 4, '*');
                    h2.Draw();
                    VerticalLine v1 = new VerticalLine(y + 1, y + 4, x, '*');
                    v1.Draw();
                    VerticalLine v2 = new VerticalLine(y + 1, y + 4, x + 20, '*');
                    v2.Draw();
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(" ");
                    Console.WriteLine("Нажмите любую кнопку, чтобы начать ввод данных заново");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
