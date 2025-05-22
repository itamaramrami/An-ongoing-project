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
