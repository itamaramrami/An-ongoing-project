using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace An_ongoing_project
{
    class Program
    {
        static void Main(string[] args)
        {

            f16 m1 = new f16();

            drone d1 = new drone();
            artillery a1 = new artillery();
            List<Weapon> helHiam1 = new List<Weapon>();
            helHiam1.Add(m1);
            helHiam1.Add(d1);
            helHiam1.Add(a1);
            IDFUnit helHiam = new IDFUnit("helHiam", "10,02,1960", helHiam1);
            List<Weapon> hel = new List<Weapon>();
            hel.Add(m1);
            hel.Add(d1);
            hel.Add(a1);
            IDFUnit hell= new IDFUnit("hel", "10,03,1960", hel);
            Terrorist.GenerateRandomTerrorists(5);
            IDF.AllDivisions();
            Aman.PrintHamasStatus();
            for (int i = 0; i < Aman.GetHamasTerrorists().Count + 1; i++)
            {
                Terrorist heighstTerrorist = Aman.GetTerroristHighestScore();

                if (heighstTerrorist != null)
                {
                    helHiam.attack();
                }
            }
            Aman.PrintHamasStatus();
        }
    }

}
