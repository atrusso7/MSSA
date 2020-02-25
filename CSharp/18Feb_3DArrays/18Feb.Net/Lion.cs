using System;
using System.Collections.Generic;
using System.Text;
using Figgle;

namespace _18Feb.Net
{
    class Lion : Feline
    {
        public void Roar()
        {
            Console.WriteLine(FiggleFonts.Ogre.Render("*ROAR*"));
        }
    }
}
