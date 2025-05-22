using System;
using System.Collections.Generic;

namespace An_ongoing_project
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateRandomTerrorists(10);

            Console.WriteLine("=== All Hamas Terrorists ===\n");

            foreach (Terrorist terrorist in Hamas.GetHamasTerrorists())
            {
                Console.WriteLine($"ID: {terrorist.GetId()}, Name: {terrorist.GetTerroristName()}, Rank: {terrorist.GetTerroristRank()}, Alive: {terrorist.IsTerroristAlive()}, Location: {terrorist.GetLocation()}");
                Console.WriteLine("Weapons: " + string.Join(", ", terrorist.GetTerroristWeapons()));
                Console.WriteLine(new string('-', 50));
            }

            foreach (Terrorist terrorist in Hamas.GetHamasTerrorists())
            {
                Terrorist heighstTerrorist = Aman.GetTerroristHighestScore();
                heighstTerrorist.KillTerrorist();
            }

            Console.WriteLine($"\nTotal terrorists in Hamas: {Hamas.GetHamasTerrorists().Count}");
        }

        static void GenerateRandomTerrorists(int count)
        {
            Random rand = new Random();

            string[] sampleNames = { "Ali", "Khaled", "Omar", "Yusuf", "Hassan", "Samir", "Nabil", "Fadi", "Tariq", "Jamal" };
            Array weaponValues = Enum.GetValues(typeof(weapon));
            Array locationValues = Enum.GetValues(typeof(location));

            for (int i = 0; i < count; i++)
            {
                string name = sampleNames[rand.Next(sampleNames.Length)];
                int rank = rand.Next(1, 6);
                var loc = (location)locationValues.GetValue(rand.Next(locationValues.Length));

                var weaponCount = rand.Next(1, 4);
                var weapons = new HashSet<weapon>();
                while (weapons.Count < weaponCount)
                {
                    weapons.Add((weapon)weaponValues.GetValue(rand.Next(weaponValues.Length)));
                }

                new Terrorist(name, rank, new List<weapon>(weapons), loc);
            }
        }
    }
}
