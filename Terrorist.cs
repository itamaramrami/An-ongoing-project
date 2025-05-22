using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
