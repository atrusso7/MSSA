using Figgle;
using System;
using System.Collections.Generic;
using System.Text;

namespace _28Jan.Net
{
    class Zombie
    {
        public string Noise()
        {
            return "Zombie goes aaahhhhhhhhhhhh!";
        }
        public string Eat()
        {
            return "Zombie likes brains!";
        }
        public string Move()
        {
            return "Zombie stumbles around";
        }
        public Zombie()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Zombie Likes Brains"));
        }
    }
}
