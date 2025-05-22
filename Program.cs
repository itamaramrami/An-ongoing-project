using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace An_ongoing_project
{
    class Program
    {
        static void Main(string[] args)
        {

            f16 m1 = new f16();
           
            drone d1 = new drone();
            artillery a1 = new artillery();
          
            List <Weapon> helHiam1 = new List<Weapon>();
            helHiam1.Add(m1);
       
            
            helHiam1.Add(d1);
            helHiam1.Add(a1);
            IDFUnit helHiam = new IDFUnit("helHiam", "10,02,1960", helHiam1);


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
