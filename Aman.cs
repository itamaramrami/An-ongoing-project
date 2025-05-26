using System;
using System.Collections.Generic;

namespace An_ongoing_project
{
    static class Aman
    {
        private static List<Terrorist> allTerrorists = Hamas.GetHamasTerrorists();

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

            foreach (Terrorist terrorist in allTerrorists)
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
        public static List<Terrorist> GetHamasTerrorists() => allTerrorists;

        public static void PrintHamasStatus()
        {
            var terrorists = Aman.GetHamasTerrorists();

            Console.WriteLine("=== All Hamas Terrorists ===\n");

            Console.WriteLine("{0,-4} | {1,-10} | {2,-4} | {3,-5} | {4,-12} | {5}",
                              "ID", "Name", "Rank", "Alive", "Location", "Weapons");
            Console.WriteLine(new string('-', 80));

            foreach (Terrorist terrorist in terrorists)
            {
                string id = terrorist.GetId().ToString();
                string name = terrorist.GetTerroristName();
                string rank = terrorist.GetTerroristRank().ToString();
                bool isAliveBool = terrorist.IsTerroristAlive();
                string location = terrorist.GetLocation().ToString();
                string weapons = string.Join(", ", terrorist.GetTerroristWeapons());

                Console.Write("{0,-4} | {1,-10} | {2,-4} | ", id, name, rank);

                if (isAliveBool)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("{0,-5}", isAliveBool ? "Yes" : "No");
                Console.ResetColor();
                Console.Write(" | {0,-12} | {1}\n", location, weapons);
            }
        }

        public static Terrorist GetTerroristById(int id)
        {
            foreach (Terrorist terrorist in allTerrorists)
            {
                if(terrorist.GetId() == id)
                {
                    return terrorist;
                }
            }
            Console.WriteLine("Terrorist not found.");
            return null;
        }
    }
}
