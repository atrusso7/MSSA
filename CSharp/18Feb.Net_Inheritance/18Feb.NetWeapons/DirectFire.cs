using System;
using System.Collections.Generic;
using System.Text;

namespace _18Feb.NetWeapons
{
    class DirectFire : Weapon
    {
        public void HowitzerLoad()
        {
            Console.WriteLine("Loading Howitzer");
        }
        public override void Fire()
        {
            Console.WriteLine("Firing artillery weapons!");
        }
    }
}
