using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_ongoing_project
{
    class Terrorist
    {
        public enum weapon
        {
            knife,
            gun,
            ak47,
            m16
        }

        private int Id;
        private string TerroristName;
        private int TerroristRanke;
        private bool IsAlive;
        private string Location;
        private List<weapon> TerroristWeapons;

        public string GetTerroristName() => this.TerroristName;
        public int GetTerroristRank() => this.TerroristRanke;
        public bool IsTerroristAlive() => this.IsAlive;
        public int GetId() => this.Id;
        public string GetLocation() => this.Location;
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


        public Terrorist(string terroristName, int terroristRanke, List<weapon> terroristWeapons,string location, bool isAlive = true)
        {
            this.TerroristName = terroristName;
            this.TerroristRanke = terroristRanke;
            this.Location = location;
            this.IsAlive = isAlive;
            this.TerroristWeapons = terroristWeapons;
        }
    }
}
