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
            f1.NumberOfBombs = 0;
            Console.WriteLine(f1.IsAvailable());
        }
    }
}
