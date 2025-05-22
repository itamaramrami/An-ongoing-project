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

        private static int GetTerroristGrade(Terrorist terrorist)
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

        public static Terrorist GetTerroristHighestScore()
        {
            int mostScore = 0;
            Terrorist terroristHighestScore = null;

            foreach (Terrorist terrorist in allTerrorist)
            {
                if (terrorist.IsTerroristAlive())
                {
                    int grade = GetTerroristGrade(terrorist);
                    if (grade > mostScore)
                    {
                        mostScore = grade;
                        terroristHighestScore = terrorist;
                    }
                }
            }

            if (terroristHighestScore == null)
            {
                Console.WriteLine("There not an alive terrorist!");
                return null;
            }

            return terroristHighestScore;
        }
        public static List<Terrorist> GetHamasTerrorists() => allTerrorist;

        public static void PrintHamasStatus()
        {
            Console.WriteLine("=== All Hamas Terrorists ===\n");

            foreach (Terrorist terrorist in Aman.GetHamasTerrorists())
            {
                string isAlive = terrorist.IsTerroristAlive() ? "Yes": "No";
                Console.WriteLine($"ID: {terrorist.GetId()}, Name: {terrorist.GetTerroristName()}, Rank: {terrorist.GetTerroristRank()}, Alive: {isAlive}, Location: {terrorist.GetLocation()}");
                Console.WriteLine("Weapons: " + string.Join(", ", terrorist.GetTerroristWeapons()));
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
