using System;
using System.Collections;
using System.Collections.Generic;

namespace _31Mar_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding characters
            var q = new Queue<string>();
            q.Enqueue("Mickey");
            q.Enqueue("Minnie");
            q.Enqueue("Donald");
            q.Enqueue("Daisy");

            //display queue
            foreach(var v in q)
                System.Console.WriteLine(v);
            
            //remove mickey
            q.Dequeue();
            System.Console.WriteLine("--------");

            foreach(var v in q)
                System.Console.WriteLine(v);
        }
    }
}
