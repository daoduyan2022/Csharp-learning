using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i =0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j % 2 == 0)
                    {
                        break;
                    }
                    else
                        Console.WriteLine("i la: {0}, j la: {1}", i, j);
                }
            }





        }
    }
}
