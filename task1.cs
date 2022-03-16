using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 3, 445, 66};
            //Console.WriteLine(GreatNum(arr));
            Console.WriteLine(greatnum(1,2,34,5,66);
        }


        static int greatnum(params int[] arr)
        {
            int result = arr[0];

            for (int i = 0; i < arr.length; i++)
            {
                if (result<arr[i])
                {
                    result = arr[i];
                }
            }

            return result;
        }
    }
}
