using System;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum = sum + (1 / i);
                 Console.WriteLine(sum);
            }
           
            Console.ReadKey();
        }
    }
}
