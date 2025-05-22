using System;
using System.Collections.Generic;

namespace An_ongoing_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Terrorist.GenerateRandomTerrorists(10);

            Console.WriteLine("=== All Hamas Terrorists ===\n");

            foreach (Terrorist terrorist in Hamas.GetHamasTerrorists())
            {
                Console.WriteLine($"ID: {terrorist.GetId()}, Name: {terrorist.GetTerroristName()}, Rank: {terrorist.GetTerroristRank()}, Alive: {terrorist.IsTerroristAlive()}, Location: {terrorist.GetLocation()}");
                Console.WriteLine("Weapons: " + string.Join(", ", terrorist.GetTerroristWeapons()));
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
