using System;
using System.Collections.Generic;
namespace Kodanalys
{
    class Program
    {
        static List<string> users = new List<string>();
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    Console.Write("Ange namn: ");
                    string userName = Console.ReadLine();

                    if (!UserExists(userName))
                    {
                        users.Add(userName);
                        Console.WriteLine("Användaren lades till.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren finns redan.");
                    }
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Användare:");
                    foreach (var user in users)
                    {
                        Console.WriteLine(user);
                    }
                }
                else if (menuChoice == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string nameToRemove = Console.ReadLine();
                    int removeedCount = users.RemoveAll(u => u == nameToRemove);
                    if (removeedCount > 0)
                    {
                        Console.WriteLine("Användaren togs bort.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuChoice == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string searchName = Console.ReadLine();

                    if (UserExists(searchName))
                    {
                        Console.WriteLine("Användaren finns.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuChoice == "5")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
        static bool UserExists(string name)
        {
            return users.Contains(name);
        }
    }
}