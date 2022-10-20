using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            string action, A, res;
            int num;
            
            
            bool exit = true;

            while (exit == true)
            {
                Console.WriteLine("Выберите программу которую хотите запустить\n'1'. Угадай число\n'2'. Таблица умножения\n'3'. Вывод делителей числа\n'4'. Выход из программы");

                action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Console.WriteLine("Угадай число от 0 до 100!");
                        Random rand = new Random();
                        int value = rand.Next(100) + 1;

                        Console.WriteLine("Введите число");
                        while (true)
                        {
                            int number = int.Parse(Console.ReadLine());

                            if (number == value)
                            {
                                Console.WriteLine("Угадали");
                                break;
                            }
                            else
                            {
                                if (number > value)
                                {
                                    Console.WriteLine("Меньше");
                                }
                                else
                                {
                                    Console.WriteLine("Больше");
                                }

                            }

                        }
                        break;


                    case "2":

                        int[,] arr = new int[10, 10];
                     
                        Console.WriteLine();
                        Console.WriteLine();                       
                        Console.WriteLine();

                        for (int i = 1; i < arr.GetLength(0); ++i)
                        {
                            for (int j = 1; j < arr.GetLength(1); ++j)
                            {

                                int sum = i * j;
                                if (i == j)
                                {
                                    arr[i, j] = sum;
                                    Console.Write(arr[i, j] + "\t");
                                }
                                else if (i > j)
                                {
                                    arr[i, j] = sum;
                                    Console.Write(arr[i, j] + "\t");
                                }
                                else if (i < j)
                                {
                                    arr[i, j] = sum;
                                    Console.Write(arr[i, j] + "\t");
                                }

                            }
                            Console.WriteLine("\n\n");
                        }
                            break;

                    case "3":

                        Console.WriteLine("Введите число");
                        A = Console.ReadLine();
                        num = Convert.ToInt32(A);
                        res = "";

                        for (int i = 1; i <= num; i++)
                        {
                            if (num % i == 0)
                            { res += i + " "; }
                        }
                        Console.WriteLine(res);
                        break;

                    case "4":

                        Environment.Exit(1);

                        break;



                        











                }
            }
        }
    }
}
