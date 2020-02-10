using Figgle;
using System;
using System.Collections.Generic;
using System.Text;

namespace _28Jan.Net
{
    class Pig
    {
        public string Noise()
        {
            return "The pig goes OINK OINK!";
        }
        public string Eat()
        {
            return "MMMMMMMMMM pig likes slop";            
        }
        public string Move()
        {
            return "Pig shuffles about";
        }
        public Pig()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Hey I'm a pig!"));
        }
    }
}
