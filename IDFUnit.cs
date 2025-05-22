using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static An_ongoing_project.Terrorist;

namespace An_ongoing_project
{
    public interface ITypesOfAttack {
        string Name { get; set; }
        int NumberOfBombs { get; set; }
        int FuelQuantity { get; set; }
        
        bool IsAvailable();
        location EffectiveAgainst { get; set; }
    }
    internal class IDFUnit
    {
        private string name; // שם החטיבה
        private DateTime DateOfEstablishment; // תאריך הקמה
        private List<ITypesOfAttack> WeaponsArsenal; // רשימה עבור כל הנשקים של החטיבה

        public IDFUnit(string name , DateTime DateOfEstablishment,List<ITypesOfAttack> WeaponsArsenal)
        {
            this.name = name;
            this.DateOfEstablishment = DateOfEstablishment;
            this.WeaponsArsenal = WeaponsArsenal;
        }

    }
}
