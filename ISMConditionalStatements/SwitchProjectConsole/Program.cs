using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("1. Расшифровка дня недели.");
                    Console.WriteLine("2. Расшифровка месяца.");
                    Console.WriteLine("3. Выполнение операций над числами.");
                    Console.WriteLine("4. Выход");
                    int menu = Convert.ToInt32(Console.ReadLine());

                    if (menu <= 4)
                    {
                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine("Выберите день недели");
                                int dayOfWeek = Convert.ToInt32(Console.ReadLine());
                                if (dayOfWeek <= 7)
                                {
                                    switch (dayOfWeek)
                                    {
                                        case 1:
                                            Console.WriteLine("Понедельник");
                                            break;
                                        case 2:
                                            Console.WriteLine("Вторник");
                                            break;
                                        case 3:
                                            Console.WriteLine("Среда");
                                            break;
                                        case 4:
                                            Console.WriteLine("Четверг");
                                            break;
                                        case 5:
                                            Console.WriteLine("Пятница");
                                            break;
                                        case 6:
                                            Console.WriteLine("Суббота");
                                            break;
                                        case 7:
                                            Console.WriteLine("Воскресенье");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка ввода данных");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Выберите месяц");
                                int monthOfYear = Convert.ToInt32(Console.ReadLine());
                                if (monthOfYear <= 12)
                                {
                                    switch (monthOfYear)
                                    {
                                        case 1:
                                            Console.WriteLine("Январь");
                                            break;
                                        case 2:
                                            Console.WriteLine("Февраль");
                                            break;
                                        case 3:
                                            Console.WriteLine("Март");
                                            break;
                                        case 4:
                                            Console.WriteLine("Апрель");
                                            break;
                                        case 5:
                                            Console.WriteLine("Май");
                                            break;
                                        case 6:
                                            Console.WriteLine("Июнь");
                                            break;
                                        case 7:
                                            Console.WriteLine("Июль");
                                            break;
                                        case 8:
                                            Console.WriteLine("Август");
                                            break;
                                        case 9:
                                            Console.WriteLine("Сентябрь");
                                            break;
                                        case 10:
                                            Console.WriteLine("Октябрь");
                                            break;
                                        case 11:
                                            Console.WriteLine("Ноябрь");
                                            break;
                                        case 12:
                                            Console.WriteLine("Декабрь");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка ввода данных");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Введите A = ");
                                double a = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите B = ");
                                double b = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Выберите действие");
                                Console.WriteLine("1. Сложение");
                                Console.WriteLine("2. Умножение");
                                Console.WriteLine("3. Вычитание");
                                Console.WriteLine("4. Деление");
                                int actionWithTwoNumbers = Convert.ToInt32(Console.ReadLine());
                                if (actionWithTwoNumbers <= 4)
                                {
                                    switch (actionWithTwoNumbers)
                                    {
                                        case 1:
                                            double addition;
                                            addition = a + b;
                                            Console.WriteLine(addition);
                                            break;
                                        case 2:
                                            double multiplication;
                                            multiplication = a * b;
                                            Console.WriteLine(multiplication);
                                            break;
                                        case 3:
                                            double subtraction;
                                            subtraction = a - b;
                                            Console.WriteLine(subtraction);
                                            break;
                                        case 4:
                                            double segmentation;
                                            segmentation = a / b;
                                            Console.WriteLine(segmentation);
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка ввода данных");
                                }
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
                catch (Exception )
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
            } while (true);
        }
    }
}

