using System;
using System.Threading;

namespace _18Feb.NetWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t~~~~~Firing Small Weapon~~~~~");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            SmallCaliber myHandgun = new SmallCaliber();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.ForegroundColor = ConsoleColor.White;
            myHandgun.HandgunLoad();
            myHandgun.StartFiring("Fire in the hole!");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.WriteLine("\n\n\n\n\t\t\t~~~~~Firing Artillery~~~~~");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            DirectFire artillery = new DirectFire();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.ForegroundColor = ConsoleColor.White;
            artillery.HowitzerLoad();
            artillery.StartFiring("Take Cover!");

            Console.WriteLine("\n\nTesting Polymorphism");
            Weapon w = myHandgun;
            w.Fire();
            w = artillery;
            w.Fire();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            IndirectFire missle = new IndirectFire();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            missle.LoadMissle();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            missle.StartFiring("\n\nMissle Inbound");
        }
    }
}
