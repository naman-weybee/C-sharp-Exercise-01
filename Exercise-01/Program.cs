using System;

namespace Exercise_01
{
    public class CurrentException : Exception
    {
        public CurrentException(string message)
            : base(message)
        {
        }
    }
    public class Program
    {
        static void Input(dynamic num)
        {
            if (int.TryParse(num, out int num1))
            {
                Console.WriteLine("----- Half Pyramid -----");
                Console.WriteLine();
                char k;
                for (int i = 0; i <= num1; i++)
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
            }
            else
            {
                throw new CurrentException("You Can not Pass Alphabet OR String in Input...!");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Line...!");
            var num = Console.ReadLine();
            try
            {
                Input(num);
            }
            catch (CurrentException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }



    //public class CurrentException : Exception
    //{
    //    public CurrentException(string message)
    //        : base(message)
    //    {
    //    }
    //}
    //public class Program
    //{
    //    static void Input(dynamic num)
    //    {
    //        if (int.TryParse(num, out int num1))
    //        {
    //            Console.WriteLine("----- Half Pyramid -----");
    //            Console.WriteLine();
    //            char k;
    //            for (int i = 1; i <= num1; i++)
    //            {
    //                k = 'A';
    //                for (int n = num1; n > i; n--)
    //                {
    //                    Console.Write(" ");
    //                }
    //                for (int j = 1; j <= i; j++)
    //                {
    //                    Console.Write(k++);
    //                }
    //                k--;
    //                for (int m = 1; m < i; m++)
    //                {
    //                    Console.Write(--k);
    //                }
    //                Console.WriteLine();
    //            }
    //        }
    //        else
    //        {
    //            throw new CurrentException("You Can not Pass Alphabet OR String in Input...!");
    //        }
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter Number Line...!");
    //        var num = Console.ReadLine();
    //        try
    //        {
    //            Input(num);
    //        }
    //        catch (CurrentException e)
    //        {
    //            Console.WriteLine(e);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
