using System;

namespace Exercise_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Line...!");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----- Half Pyramid -----");
            Console.WriteLine();
            char k;

            for (int i = 1; i <= num; i++)
            {
                k = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k++ + " ");
                }
                k--;
                for (int m = 1; m < i; m++)
                {
                    Console.Write(--k + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter Number Line...!");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("----- Full Pyramid -----");

        //    Console.WriteLine();
        //    char k;

        //    for (int i = 1; i <= num; i++)
        //    {
        //        k = 'A';
        //        for (int n = num; n > i; n--)
        //        {
        //            Console.Write(" ");
        //        }
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write(k++);
        //        }
        //        k--;
        //        for (int m = 1; m < i; m++)
        //        {
        //            Console.Write(--k);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //}
    }
}
