using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

        static int count1(int a)
        {
            int counter = 0;
            for (int i = 1; a > 0; i++)
            {
                if (a % 2 == 1)
                {
                    a = a / 2;
                    counter++;
                }
                else
                {
                    a = a / 2;
                }

            }
            return counter;
        }









    }
}
