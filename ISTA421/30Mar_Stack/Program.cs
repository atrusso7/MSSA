using System;
using System.Collections;
using System.Collections.Generic;

namespace _30Mar_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // var Stackin = new Stack<int>();
            // Stackin.Push(0);
            // Stackin.Push(23);
            // Stackin.Push(29);

            // //Pop
            // int popIt = Stackin.Pop();
            // System.Console.WriteLine($"Pop = {popIt}");
            // foreach(int i in Stackin)
            //     System.Console.WriteLine(i);

            // //Peek
            // int peekIt = Stackin.Peek();
            // Stackin.Push(29);            
            // System.Console.WriteLine($"\n\nPeek = {peekIt}");
            // foreach(int i in Stackin)
            //     System.Console.WriteLine(i);
            
            //Remove Minnie
            var byeMinnie = new Stack<String>();
            byeMinnie.Push("Daisy");
            byeMinnie.Push("Donald");
            byeMinnie.Push("Mickey");
            byeMinnie.Push("Minnie");

            foreach(string i in byeMinnie)
                System.Console.WriteLine(i);
            Console.WriteLine("\nBye " + byeMinnie.Pop() + "\n");
            foreach(string i in byeMinnie)
                System.Console.WriteLine(i);
        }
    }
}
