using System;
using System.Collections.Generic;

namespace An_ongoing_project
{
    class Program
    {
        static void Main(string[] args)
        {
            f16 m1 = new f16();
            drone d1 = new drone();
            artillery a1 = new artillery();

            List<Weapon> helHiam1 = new List<Weapon>();
            helHiam1.Add(m1);
            helHiam1.Add(d1);
            helHiam1.Add(a1);
            IDFUnit helHiam = new IDFUnit("helHiam", "10,02,1960", helHiam1);

            Console.WriteLine("=== Welcome to 8200 system! ===\n");

            bool validInput;
            int amountOfTerrorists;
            string amountOfTerroristsInput;
            do
            {
                Console.Write("Please enter the amount of terrorists: ");
                amountOfTerroristsInput = Console.ReadLine();
                validInput = int.TryParse(amountOfTerroristsInput, out amountOfTerrorists) && amountOfTerrorists > 0 && amountOfTerrorists < 21;

                if (validInput)
                {
                    Console.WriteLine($"Creating {amountOfTerrorists} terrorists...");
                    Terrorist.GenerateRandomTerrorists(amountOfTerrorists);
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number between 1-20.");
                }

            } while (!validInput);

            while (true)
            {
                string input;
                int userChoice;
                do
                {
                    Console.WriteLine("\tEnter 1 to show all terrorist");
                    Console.WriteLine("\tEnter 2 to show all IDF units");
                    Console.WriteLine("\tEnter 3 to show the most wanted terrorist");
                    Console.WriteLine("\tEnter 4 to kill terrorist by id");
                    Console.WriteLine("\tEnter 5 to kill the wanted terrorist");
                    Console.WriteLine("\tEnter 0 to exit.");
                    input = Console.ReadLine();
                    validInput = int.TryParse(input, out userChoice) && userChoice >= 0 && userChoice < 6;
                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input, please enter one of the options.");
                    }

                } while (!validInput);

                if (userChoice == 0)
                    break;

                if (userChoice == 1)
                {
                    Aman.PrintHamasStatus();
                }
                else if (userChoice == 2)
                {
                    IDF.AllDivisions();
                }
                else if (userChoice == 3)
                {
                    Terrorist highestTerrorist = Aman.GetTerroristHighestScore();
                    if (highestTerrorist != null)
                    {
                        Console.WriteLine($"The highest terrorist is {highestTerrorist.GetTerroristName()} with id: {highestTerrorist.GetId()}");
                    }
                }
                else if (userChoice == 4)
                {
                    int terroristIdToKill;
                    do
                    {
                        Console.WriteLine("Enter terrorist id to kill: ");
                        input = Console.ReadLine();
                        validInput = int.TryParse(input, out terroristIdToKill) && terroristIdToKill > 0 && terroristIdToKill <= Aman.GetHamasTerrorists().Count;
                        if (validInput)
                        {
                            Terrorist terroristToKill = Aman.GetTerroristById(terroristIdToKill);
                            helHiam.attack(terroristToKill);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input, enter a number between 1 to the sum of terrorists ({Aman.GetHamasTerrorists().Count} terrorists at all).");
                        }
                    } while (!validInput);
                }
                else if (userChoice == 5)
                {
                    Terrorist highestTerrorist = Aman.GetTerroristHighestScore();
                    if (highestTerrorist != null)
                    {
                        helHiam.attack(highestTerrorist);
                    }
                }
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}
