using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
     internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите какую октаву вы хотите. F1-первая, F2-вторая");
            Vod();
        }
        static void Vod()
        {
            while (true)
            {

                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.F1)
                {
                    int[] oct1 = new int[] { 260, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                    Octava1(oct1);
                }
                if (a.Key == ConsoleKey.F2)
                {
                    int[] oct2 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 923, 987 };
                    Octava2(oct2);
                }
                if (a.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void Octava1(int[] massive)
        {
            Console.WriteLine("Вы выбрали первую октаву.");
            while (true)
            {
                ConsoleKeyInfo b = Console.ReadKey();
                if (b.Key == ConsoleKey.A)
                {
                    Console.Beep(massive[0], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.O)
                {
                    Console.Beep(massive[1], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.E)
                {
                    Console.Beep(massive[2], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.R)
                {
                    Console.Beep(massive[3], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.T)
                {
                    Console.Beep(massive[4], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Y)
                {
                    Console.Beep(massive[5], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.U)
                {
                    Console.Beep(massive[6], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.I)
                {
                    Console.Beep(massive[7], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.P)
                {
                    Console.Beep(massive[8], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.S)
                {
                    Console.Beep(massive[9], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.D)
                {
                    Console.Beep(massive[10], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.F)
                {
                    Console.Beep(massive[11], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void Octava2(int[] massive)
        {
            Console.WriteLine("Вы выбрали вторую октаву.");
            while (true)
            {
                ConsoleKeyInfo b = Console.ReadKey();
                if (b.Key == ConsoleKey.F)
                {
                    Console.Beep(massive[0], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.G)
                {
                    Console.Beep(massive[1], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.H)
                {
                    Console.Beep(massive[2], 400);
                    Console.Clear();
                }
                if (b.Key ==
                ConsoleKey.J)
                {
                    Console.Beep(massive[3], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.K)
                {
                    Console.Beep(massive[4], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.L)
                {
                    Console.Beep(massive[5], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Z)
                {
                    Console.Beep(massive[6], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.X)
                {
                    Console.Beep(massive[7], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.C)
                {
                    Console.Beep(massive[8], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.V)
                {
                    Console.Beep(massive[9], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.N)
                {
                    Console.Beep(massive[10], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.M)
                {
                    Console.Beep(massive[11], 400);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }




}
    

