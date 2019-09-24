using System;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Введите число");
            int n;
            double sum = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
            } while (n != 0);
            Console.WriteLine(sum);
            }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
            Console.ReadKey();
        }
    }
}
