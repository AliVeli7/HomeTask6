namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 445, 66 };
            Console.WriteLine(GreatNum(arr));
        }


        static int GreatNum(int[] arr, int a = 0)
        {

            if (a < arr.Length - 1)
            {
                if (arr[a] > arr[a + 1])
                {

                    int i = arr[a];
                    arr[a] = arr[a + 1];
                    arr[a + 1] = i;
                    a++;
                    return GreatNum(arr, a);
                }
                else
                {
                    return GreatNum(arr, a + 1);
                }


            }

            return arr[a];

        }









    }
}