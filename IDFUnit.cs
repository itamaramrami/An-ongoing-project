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
        private string DateOfEstablishment; // תאריך הקמה
        private List<Weapon> WeaponsArsenal; // רשימה עבור כל הנשקים של החטיבה

        public IDFUnit(string name , string DateOfEstablishment,List<Weapon> WeaponsArsenal)
        {
            this.name = name;
            this.DateOfEstablishment = DateOfEstablishment;
            this.WeaponsArsenal = WeaponsArsenal;
        }
        public void attack()
        {
            Terrorist heighstTerrorist = Aman.GetTerroristHighestScore();
            if (heighstTerrorist.GetLocation() == location.Building)
            {
               if (WeaponsArsenal[0].IsAvailable())
                {
                    WeaponsArsenal[0].bombing();
                    heighstTerrorist.KillTerrorist();
                    Console.WriteLine("The attack was carried out successfully.");
                }
                else
                {
                    Console.WriteLine("The attack is not available.");
                }

            }
            if (heighstTerrorist.GetLocation() == location.Vehicle)
            {
               if (WeaponsArsenal[1].IsAvailable())
                {
                    WeaponsArsenal[1].bombing();
                    heighstTerrorist.KillTerrorist();

                    Console.WriteLine("The attack was carried out successfully.");
                }
                else
                {
                    Console.WriteLine("The attack is not available.");
                }

            }
            if (heighstTerrorist.GetLocation() == location.OpenSpace)
            {
               if (WeaponsArsenal[2].IsAvailable())
                {
                    WeaponsArsenal[2].bombing();
                    heighstTerrorist.KillTerrorist();

                    Console.WriteLine("The attack was carried out successfully.");
                }
                else
                {
                    Console.WriteLine("The attack is not available.");
                }

            }
        }





    }
}
