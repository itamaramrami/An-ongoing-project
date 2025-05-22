using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static An_ongoing_project.Terrorist;

namespace An_ongoing_project
{
    internal class Weapon : ITypesOfAttack
    {
        public string Name { get; set; }
        public location EffectiveAgainst { get; set; }
        public int NumberOfBombs { get; set; }
        public int FuelQuantity { get; set; }

        public Weapon(string Name, location effectiveAgainst, int NumberOfBombs, int FuelQuantity)
        {
            this.Name = Name;
            this.EffectiveAgainst = effectiveAgainst;
            this.NumberOfBombs = NumberOfBombs;
            this.FuelQuantity = FuelQuantity;
        }
        public bool IsAvailable()
        {
            return NumberOfBombs > 0 && FuelQuantity > 0;
        }
        public void bombing()
        {
            this.NumberOfBombs -= 1;
            this.FuelQuantity -= 20;
        }



    }

    internal class f16 : Weapon
    {

        public f16(): base("F16", location.Building, 8, 100) { }
        


    }
    internal class drone : Weapon
    {

        public drone(): base("drone", location.Vehicle, 3, 60) { }
        
    }
    internal class artillery : Weapon
    {

        public artillery(): base("artillery", location.OpenSpace, 40, 50) { }
        
    }
}
