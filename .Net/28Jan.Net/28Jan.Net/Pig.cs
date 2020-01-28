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
        public string Eat(string food)
        {
            if (food == "slop")
                return "MMMMMMMMMM pig likes slop";
            else
                return "Pig has never had this food before. Pig is unsure.";
        }
    }
}
