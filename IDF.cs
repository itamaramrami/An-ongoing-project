using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_ongoing_project
{
    internal static class IDF
    {
        private static Random rnd = new Random();
        static List<IDFUnit> ListOfDivisions = new List<IDFUnit>();

        public static void AddDivision(IDFUnit division)
        {
            ListOfDivisions.Add(division);
        }
        public static void AllDivisions()
        {
           foreach(IDFUnit divis in ListOfDivisions)
            {
                Console.WriteLine("division:");
                Console.WriteLine($"name of division: {divis.getname()} date of establishment: {divis.getstablishment()} ");
                Console.WriteLine("Weapons available:");
                divis.WeaponsAvailable();
            }
        }
        public static void CreatingDivisions(int number)
        {
            List<string> attackingForces = new List<string>
        {
            "חיל רגלים",
            "חיל שריון",
            "חיל הנדסה קרבית",
            "חיל האוויר",
            "חיל הים",
            "חיל התותחנים",
            "סיירות מובחרות",
            "חיל מודיעין קרבי"
        };
            for (int i =0; i<number; i++)
            {
                int randomIndex = rnd.Next(7); 
                string randomName = attackingForces[randomIndex];
                IDFUnit randomName  = new IDFUnit(randomName, "10,03,1960", hel);
            }
        }
    }
}
