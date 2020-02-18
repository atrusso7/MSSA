using System;
using System.Collections.Generic;
using System.Text;
using Figgle;

namespace _18Feb.NetWeapons
{
    class Weapon
    {
        public Weapon()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FiggleFonts.Standard.Render("WEAPON ENGAGED"));
        }
        public void StartFiring(string firingnoise)
        {
            Console.WriteLine(FiggleFonts.Standard.Render(firingnoise));
        }
        public virtual void Fire()
        {
            Console.WriteLine("Firing weapon");
        }
    }
}
