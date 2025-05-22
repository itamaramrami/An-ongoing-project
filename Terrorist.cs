using System;
using System.Collections.Generic;

namespace An_ongoing_project
{
    class Terrorist
    {
        private static int IdCounter = 1;
        private int Id;
        private string TerroristName;
        private int TerroristRanke;
        private bool IsAlive;
        private List<weapon> TerroristWeapons;
        private location TerroristLocation;

        public string GetTerroristName() => this.TerroristName;
        public int GetTerroristRank() => this.TerroristRanke;
        public bool IsTerroristAlive() => this.IsAlive;
        public int GetId() => this.Id;
        public location GetLocation() => this.TerroristLocation;
        public void KillTerrorist()
        {
            if (IsTerroristAlive())
            {
                this.IsAlive = false;
                Console.WriteLine($"Terrorist {this.GetTerroristName()} ID: {this.GetId()} killed successfully!");
            }
            else
            {
                Console.WriteLine($"terrorist {this.GetTerroristName()} already dead.");
            }
        }
        public List<weapon> GetTerroristWeapons() => this.TerroristWeapons;
        private static int GenerateNewId() => IdCounter++;
         public static void GenerateRandomTerrorists(int count)
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

                var weaponCount = rand.Next(1, 5);
                var weapons = new HashSet<weapon>();
                while (weapons.Count < weaponCount)
                {
                    weapons.Add((weapon)weaponValues.GetValue(rand.Next(weaponValues.Length)));
                }

                new Terrorist(name, rank, new List<weapon>(weapons), loc);
            }
        }

        public Terrorist(string terroristName, int terroristRanke, List<weapon> terroristWeapons,location location, bool isAlive = true)
        {
            this.Id = GenerateNewId();
            this.TerroristName = terroristName;
            this.TerroristRanke = terroristRanke;
            this.TerroristLocation = location;
            this.IsAlive = isAlive;
            this.TerroristWeapons = terroristWeapons;

            Hamas.SetNewTerrorist(this);
        }
    }
}
