using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
