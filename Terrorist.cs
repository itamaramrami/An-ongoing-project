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

        private string TerroristName;
        private int TerrorisRanke;
        private bool IsAlive;
        private List<weapon> TerroristWeapons;

        public string GetTerroristName() => this.TerroristName;
        public int GetTerroristRank() => this.TerrorisRanke;
        public bool IsTerroristAlive() => this.IsAlive;
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

        public Terrorist(string terroristName, int terroristRanke, bool isAlive, List<weapon> terroristWeapons)
        {
            this.TerroristName = terroristName;
            this.TerrorisRanke = terroristRanke;
            this.IsAlive = isAlive;
            this.TerroristWeapons = terroristWeapons;
        }
    }
}
