using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_ongoing_project
{
    public interface ITypesOfAttack {
        string Name { get; set; }
        List<string> EffectiveAgainst { get; set; }
        int NumberOfBombs { get; set; }
        int FuelQuantity { get; set; }
        
        bool IsAvailable();

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
