using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static An_ongoing_project.Terrorist;

namespace An_ongoing_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Weapon> nnn = new List<Weapon>();
            f16 f1 = new f16();
            f1.bombing();
            Console.WriteLine( f1.NumberOfBombs);
            Console.WriteLine(f1.FuelQuantity);
            Console.WriteLine(f1.IsAvailable());
            Terrorist terrorist = new Terrorist("Abu Jihad", 5,
                new List<weapon> { weapon.gun, weapon.knife}, "car");
            Terrorist terrorist2 = new Terrorist("Muhamad", 4,
                new List<weapon> { weapon.ak47, weapon.m16 }, "building");

            Hamas.SetNewTerrorist(terrorist);
            Hamas.SetNewTerrorist(terrorist2);

            Console.WriteLine(Aman.GetTerroristHighestScore().GetTerroristName());
        }
    }
}
