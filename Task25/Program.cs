using System;

namespace Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            int b = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < b; i++)
                result *= a;

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
