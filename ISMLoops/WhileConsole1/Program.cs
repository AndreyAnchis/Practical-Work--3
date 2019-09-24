using System;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("N = ");
                int n = Convert.ToInt32(Console.ReadLine());
                int k = 0;
                if (n > 0)
                {
                    while (k != Math.Floor(Math.Log(n, 3)) + 1)
                    {
                        k++;
                    }
                    Console.WriteLine(k);
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            Console.ReadKey();
        }
    }
}
