using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_ongoing_project
{
    internal class Weapon : ITypesOfAttack
    {
        public string Name { get; set; }
        public List<string> EffectiveAgainst { get; set; }
        public int NumberOfBombs { get; set; }
        public int FuelQuantity { get; set; }

        public Weapon(string Name, List<string>EffectiveAgainst, int NumberOfBombs, int FuelQuantity)
        {
            this.Name = Name;
            this.EffectiveAgainst = EffectiveAgainst;
            this.NumberOfBombs = NumberOfBombs;
            this.FuelQuantity = FuelQuantity;
        }
        public bool IsAvailable()
        {
            return NumberOfBombs > 0 && FuelQuantity > 0;
        }



    }

    internal class f16 : Weapon
    {

        public f16(): base("F16", new List<string> { "Buildings" }, 8, 100) { }
        
    }
    internal class drone : Weapon
    {

        public drone(): base("drone", new List<string> { "people", "vehicle" }, 3, 60) { }
        
    }
    internal class artillery : Weapon
    {

        public artillery(): base("artillery", new List<string> { "Open spaces" }, 40, 50) { }
        
    }
}
