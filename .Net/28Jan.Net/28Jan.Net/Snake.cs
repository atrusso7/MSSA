using Figgle;
using System;
using System.Collections.Generic;
using System.Text;

namespace _28Jan.Net
{
    class Snake
    {
        public string Noise()
        {
            return "The snake goes HISSSSS";
        }
        public string Eat()
        {
            return "Snake eats chicken eggs whole";
        }
        public string Move()
        {
            return "Snake slithers about";
        }
        public Snake()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Hi, I'm a Snake"));
        }
    }
}
