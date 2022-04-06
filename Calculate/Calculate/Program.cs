using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Length = 10;
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width = 15;
            Console.WriteLine("1-AreA Rectangular 2- Area square 0-exit");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    rectangle.CalcArea();
                    break;
                case 2:
                    square.CalcArea();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("dogru reqem daxil et");
                    break;
            }
        }
    }
}
