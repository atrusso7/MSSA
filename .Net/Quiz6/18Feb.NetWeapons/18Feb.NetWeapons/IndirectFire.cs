using System;
using System.Collections.Generic;
using System.Text;

namespace _18Feb.NetWeapons
{
    class IndirectFire : Weapon
    {
        public void LoadMissle()
        {
            Console.WriteLine("Missle locked");
        }
        public override void Fire()
        {
            Console.WriteLine("Firing missle");
        }
    }
}
