using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, num, i;
            Console.WriteLine("min:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("max:");
            n2 = int.Parse(Console.ReadLine());
            for (num = n1; num < n2; num++)
            {
                decimal sum = 0;
                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum = sum + i;
                }
                if (sum == num)
                {
                }



        }
    }
}
