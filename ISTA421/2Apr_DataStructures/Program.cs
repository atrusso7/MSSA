using System.Collections.Generic;
using System;

namespace _2Apr_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
           var myList = new LinkedList<string>();
           myList.AddLast("Sun");
           myList.AddLast("Mercury");
           myList.AddLast("Venus");
           myList.AddLast("Earth");
           myList.AddLast("Mars");
           myList.AddLast("Jupiter");
           myList.AddLast("Saturn");

           foreach(var planet in myList)
                System.Console.WriteLine(planet);
            System.Console.WriteLine("=================");
        

           LinkedListNode<string> node = myList.Find("Saturn");
           myList.AddAfter(node, "Uranus");
           myList.RemoveFirst();
           myList.Remove("Mars");

           foreach(var planet in myList)
            System.Console.WriteLine(planet);
        }
    }
}
