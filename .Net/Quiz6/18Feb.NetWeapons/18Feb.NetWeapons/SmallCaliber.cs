using System;
using System.Collections.Generic;
using System.Text;

namespace _18Feb.NetWeapons
{
    class SmallCaliber : Weapon
    {
        public void HandgunLoad()
        {
            Console.WriteLine("Loading Cold 45");
        }
        public override void Fire()
        {
            Console.WriteLine("Firing small caliber weapons!");
        }
    }
}
