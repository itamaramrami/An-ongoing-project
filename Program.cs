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
            Terrorist terrorist = new Terrorist("Abu Jihad", 5,
                new List<weapon> { weapon.gun, weapon.knife }, location.Building);
            Terrorist terrorist2 = new Terrorist("Muhamad", 4,
                new List<weapon> { weapon.ak47, weapon.m16 }, location.Vehicle);

            Console.WriteLine(terrorist.GetId());
            Console.WriteLine(terrorist2.GetId());
            Hamas.SetNewTerrorist(terrorist);
            Hamas.SetNewTerrorist(terrorist2);

            Console.WriteLine(Aman.GetTerroristHighestScore().GetTerroristName());
        }
    }
}
