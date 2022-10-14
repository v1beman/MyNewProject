using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, degree, numberBeforeDegree, sqrt, x, y;
            string action;
            int z;
            long fact = 1;
            bool exit = true;

            while(exit == true)

            
                
            {
                
                Console.ReadLine();
                Console.WriteLine("Введите число 1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число 2");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/' 'n' '√' '%' '!' 'exit'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        Console.WriteLine(firstValue / secondValue);
                        break;
                    case "n":
                        Console.WriteLine("Введите число которое хотите возвести в степень");
                        numberBeforeDegree = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите степень");
                        degree = double.Parse(Console.ReadLine());
                        Console.WriteLine(Math.Pow(numberBeforeDegree, degree));
                        break;

                    case "√":
                        Console.WriteLine("Введите число из которого хотите найти квадратный корень");
                        sqrt = double.Parse(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(sqrt));
                        break;
                    case "%":
                        Console.WriteLine("Введите число от которго хотите посчитать процент");
                        x = double.Parse(Console.ReadLine());
                        y = 1;
                        Console.WriteLine(System.Math.Round((double)(x * y / 100)));
                        break;

                    case "!":
                        Console.WriteLine("Введите число из которого хотите найти факториал");
                        z = int.Parse(Console.ReadLine());
                        if (fact == 0)
                        {
                            Console.WriteLine(1);
                        }

                        {


                            for (int i = 1; i <= z; i++)
                            {
                                fact *= i;
                            }
                            Console.WriteLine(fact);
                            Console.ReadLine();

                            break;
                        }



                    case "exit":

                        Environment.Exit(1);

                        break;
                
                }
            


            
                {
                   
                }

            
                
            
                }

                   }
            

        }

    }



