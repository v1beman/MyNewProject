using Notes2;
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
           

            Zametka2 Zam1 = new Zametka2();            
            Zam1.Name = "  Придти на пары";
            Zam1.Description = "  С первой по пятую";
            
            Zametka2 Zam2 = new Zametka2();
            Zam2.Name = "  Пойти погулять";
            Zam2.Description = "  В 8 вечера";

            Zametka2 Zam3 = new Zametka2();
            Zam3.Name = "  Сходить в магазин";
            Zam3.Description = "  Купить еду";

            Zametka2 Zam4 = new Zametka2();
            Zam4.Name = "  Сходить в спорт зал";
            Zam4.Description = "  Тренеровка рук";

            Zametka2 Zam5 = new Zametka2();
            Zam5.Name = "  Сделать практические";
            Zam5.Description = "  Python, C#";

            List<string> ZamDate = new List<string>();
            ZamDate.Add("  Заметки 13.11.2023");
            ZamDate.Add("  Заметки 14.11.2023");
            ZamDate.Add("  Заметки 15.11.2023");


            while (true)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.RightArrow)
                {
                    
                    Console.Clear();
                    Console.WriteLine(ZamDate[0]);
                    Console.WriteLine(Zam1.Name);
                    Console.WriteLine(Zam2.Name);

                 
                    int position = 1;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    ConsoleKeyInfo clavisha = Console.ReadKey();                   

                    while (clavisha.Key != ConsoleKey.Enter)
                    {                       
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                            Console.Clear();
                            Console.WriteLine(ZamDate[0]);
                            Console.WriteLine(Zam1.Name);
                            Console.WriteLine(Zam2.Name);
                        }
                        else if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                            Console.Clear();
                            Console.WriteLine(ZamDate[0]);
                            Console.WriteLine(Zam1.Name);
                            Console.WriteLine(Zam2.Name);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                       
                    }
                    if (position == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Zam1.Name + "\n" + Zam1.Description + "\n" + "Время создания 10.11.2023");
                    }
                    while (clavisha.Key != ConsoleKey.Enter | a.Key != ConsoleKey.RightArrow)
                    {
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                            Console.Clear();
                            Console.WriteLine(ZamDate[0]);
                            Console.WriteLine(Zam2.Name);
                        }
                        else if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                            Console.Clear();
                            Console.WriteLine(ZamDate[0]);
                            Console.WriteLine(Zam2.Name);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                    }
                    if (position == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Zam2.Name + "\n" + Zam2.Description + "\n" + "Время создания 9.11.2023");
                    }
                    
                }
                   
                ConsoleKeyInfo b = Console.ReadKey();

                if (b.Key == ConsoleKey.RightArrow)
                {

                    Console.Clear();
                    Console.WriteLine(ZamDate[1]);
                    Console.WriteLine(Zam3.Name);
                    Console.WriteLine(Zam4.Name);

                    int position2 = 1;
                    Console.SetCursorPosition(0, position2);
                    Console.WriteLine("->");
                    ConsoleKeyInfo clavisha2 = Console.ReadKey();

                    while (clavisha2.Key != ConsoleKey.Enter)
                    {
                        if (clavisha2.Key == ConsoleKey.UpArrow)
                        {
                            position2--;
                            Console.Clear();
                            Console.WriteLine(ZamDate[1]);
                            Console.WriteLine(Zam3.Name);
                            Console.WriteLine(Zam4.Name);
                        }
                        else if (clavisha2.Key == ConsoleKey.DownArrow)
                        {
                            position2++;
                            Console.Clear();
                            Console.WriteLine(ZamDate[1]);
                            Console.WriteLine(Zam3.Name);
                            Console.WriteLine(Zam4.Name);
                        }
                        Console.SetCursorPosition(0, position2);
                        Console.WriteLine("->");
                        clavisha2 = Console.ReadKey();
                    }
                    if (position2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Zam3.Name + "\n" + Zam3.Description + "\n" + "Время создания 6.11.2023");
                    }
                    while (clavisha2.Key != ConsoleKey.Enter)
                    {
                        if (clavisha2.Key == ConsoleKey.UpArrow)
                        {
                            position2--;
                            Console.Clear();
                            Console.WriteLine(ZamDate[1]);
                            Console.WriteLine(Zam3.Name);
                            Console.WriteLine(Zam4.Name);
                        }
                        else if (clavisha2.Key == ConsoleKey.DownArrow)
                        {
                            position2++;
                            Console.Clear();
                            Console.WriteLine(ZamDate[1]);
                            Console.WriteLine(Zam3.Name);
                            Console.WriteLine(Zam4.Name);
                        }
                        Console.SetCursorPosition(0, position2);
                        Console.WriteLine("->");
                        clavisha2 = Console.ReadKey();
                    }
                    if (position2 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Zam4.Name + "\n" + Zam4.Description + "\n" + "Время создания 5.11.2023");
                    }

                }

                ConsoleKeyInfo c = Console.ReadKey();

                if (c.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.WriteLine(ZamDate[2]);
                    Console.WriteLine(Zam5.Name);

                    int position3 = 1;
                    Console.SetCursorPosition(0, position3);
                    Console.WriteLine("->");
                    ConsoleKeyInfo clavisha3 = Console.ReadKey();

                    while (clavisha3.Key != ConsoleKey.Enter)
                    {
                        if (clavisha3.Key == ConsoleKey.UpArrow)
                        {
                            position3--;
                            Console.Clear();
                            Console.WriteLine(ZamDate[1]);
                            Console.WriteLine(Zam5.Name);                          
                        }
                        else if (clavisha3.Key == ConsoleKey.DownArrow)
                        {
                            position3++;
                            Console.Clear();
                            Console.WriteLine(ZamDate[1]);
                            Console.WriteLine(Zam3.Name);
                            Console.WriteLine(Zam4.Name);
                        }
                        Console.SetCursorPosition(0, position3);
                        Console.WriteLine("->");
                        clavisha3 = Console.ReadKey();
                    }
                    if (position3 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Zam5.Name + "\n" + Zam5.Description + "\n" + "Время создания 1.11.2023");
                    }
                }

            }
            
        }
        
        
        
    }




}