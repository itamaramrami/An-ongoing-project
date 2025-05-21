using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_ongoing_project
{
    static class Hamas
    {
        private static string DateOfEstablishment;
        private static Terrorist CurrentCommander;
        private static List<Terrorist> HamasTerrorists = new List<Terrorist>();

        public static string GetDataOfEstablishmentOfHamas() => DateOfEstablishment;
        public static Terrorist GetCurrentCommanderOfHamas() => CurrentCommander;
        public static List<Terrorist> GetHamasTerrorists() => HamasTerrorists;

        public static void SetNewTerrorist(Terrorist newTerrorist)
        {
            HamasTerrorists.Add(newTerrorist);
        }
    }
}
