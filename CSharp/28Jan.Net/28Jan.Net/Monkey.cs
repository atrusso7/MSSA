using Figgle;
using System;
using System.Collections.Generic;
using System.Text;

namespace _28Jan.Net
{
    class Monkey
    {
        public string Noise()
        {
            return "The monkey goes OOO OOO AAHH AHHH!";
        }
        public string Eat()
        {
            return "Monkey likes bananas!";
        }
        public string Move()
        {
            return "Monkey swings through the trees";
        }
        public Monkey()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Monkey Smash!"));
        }
    }
}
