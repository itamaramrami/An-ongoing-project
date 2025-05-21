using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static An_ongoing_project.Terrorist;

namespace An_ongoing_project
{
    static class Aman
    {
        private static List<Terrorist> allTerrorist = Hamas.GetHamasTerrorists();

        public static int GetTerroristGrade(Terrorist terrorist)
        {
            int weaponRank = 0;
            foreach (weapon weapon in terrorist.GetTerroristWeapons())
            {
                switch (weapon)
                {
                    case weapon.knife:
                        weaponRank += 1;
                        break;
                    case weapon.gun:
                        weaponRank += 2;
                        break;
                    case weapon.ak47:
                        weaponRank += 3;
                        break;
                    case weapon.m16:
                        weaponRank += 3;
                        break;
                    default:
                        Console.WriteLine("Not valid weapon.");
                        break;
                }
            }
            return weaponRank * terrorist.GetTerroristRank();
        }
    }
}
