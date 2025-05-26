using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static An_ongoing_project.Terrorist;

namespace An_ongoing_project
{
    public interface ITypesOfAttack
    {
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

        public IDFUnit(string name, string DateOfEstablishment, List<Weapon> WeaponsArsenal)
        {
            this.name = name;
            this.DateOfEstablishment = DateOfEstablishment;
            this.WeaponsArsenal = WeaponsArsenal;
            IDF.AddDivision(this);

        }
        public string getname()
        {
            return this.name;
        }
        public string getstablishment()
        {
            return this.DateOfEstablishment;
        }
        public void WeaponsAvailable()
        {
            foreach (Weapon item in WeaponsArsenal)
            {
                Console.WriteLine($"Name: {item.Name}, Bombs: {item.NumberOfBombs}, Fuel: {item.FuelQuantity}");
            }
        }


        public void attack(Terrorist terroristToKill)
        {
            if (terroristToKill.GetLocation() == location.Building)
            {
                if (WeaponsArsenal[0].IsAvailable())
                {
                    WeaponsArsenal[0].bombing();
                    terroristToKill.KillTerrorist();
                    Console.WriteLine($"The terrorist: id:{terroristToKill.GetId()} name:{terroristToKill.GetTerroristName()} Bombed by:{WeaponsArsenal[0].Name}" +
                        $" The remaining weapons: Bombs:{WeaponsArsenal[0].NumberOfBombs} fuel:{WeaponsArsenal[0].FuelQuantity}");
                }
                else
                {
                    Console.WriteLine("The attack is not available.");
                }

            }
            if (terroristToKill.GetLocation() == location.Vehicle)
            {
                if (WeaponsArsenal[1].IsAvailable())
                {
                    WeaponsArsenal[1].bombing();
                    terroristToKill.KillTerrorist();

                    Console.WriteLine($"The terrorist: id:{terroristToKill.GetId()} name:{terroristToKill.GetTerroristName()} Bombed by:{WeaponsArsenal[1].Name}" +
                                  $" The remaining weapons: Bombs:{WeaponsArsenal[1].NumberOfBombs} fuel:{WeaponsArsenal[1].FuelQuantity}");
                }
                else
                {
                    Console.WriteLine("The attack is not available.");
                }

            }
            if (terroristToKill.GetLocation() == location.OpenSpace)
            {
                if (WeaponsArsenal[2].IsAvailable())
                {
                    WeaponsArsenal[2].bombing();
                    terroristToKill.KillTerrorist();

                    Console.WriteLine($"The terrorist: id:{terroristToKill.GetId()} name:{terroristToKill.GetTerroristName()} Bombed by:{WeaponsArsenal[2].Name}" +
                         $" The remaining weapons: Bombs:{WeaponsArsenal[2].NumberOfBombs} fuel:{WeaponsArsenal[2].FuelQuantity}");
                }
                else
                {
                    Console.WriteLine("The attack is not available.");
                }

            }
        }





    }
}
