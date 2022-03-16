using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            count1(777);
        }


        static void count1(int a, int counter= 0)
        {
           if (a!=0)
            {

             if (a%2==1)
            {
                
                count1(a/2, counter=counter+1);
              }else
             {
               count1(a/2,counter);
              }

            }
            else
            {
                Console.WriteLine(counter);
            }
            
        }

    }
}
