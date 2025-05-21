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
            List<Terrorist.weapon> weapons = new List<Terrorist.weapon>
        {
            Terrorist.weapon.ak47,
            Terrorist.weapon.knife,
            Terrorist.weapon.ak47
        };

            Terrorist terrorist = new Terrorist("Abu Jihad", 5, true, weapons);
            Hamas.SetNewTerrorist(terrorist);
            Console.WriteLine(Aman.GetTerroristGrade(terrorist));
        }
    }
}
