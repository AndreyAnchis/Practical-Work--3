using System;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("A = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                double res = 0;
                if (a < b)
                {
                    for (double i = a; i <= b; i++)
                    {
                        res = res + Math.Pow(i, 2);
                    }
                    Console.WriteLine(res);
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            Console.ReadKey();
        }
    }
}
