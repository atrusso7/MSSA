using System;
using System.Collections;
using System.Collections.Generic;

namespace _7Apr_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            //hashset doesn't allow duplicates to be displayed
            System.Console.WriteLine("[===Hash Set===]\n");
            var myHashSet = new HashSet<string>();
            myHashSet.Add("Mickey");
            myHashSet.Add("Minnie");
            myHashSet.Add("Donald");
            myHashSet.Add("Daisy");
            myHashSet.Add("Pluto");
            myHashSet.Add("Pluto");
            
            foreach (var name in myHashSet)
                System.Console.Write(name + " ");

            // //sorted list uses key to order list
            System.Console.WriteLine("\n\n[===Sorted List===]\n");
            var mySortedList = new SortedList();
            mySortedList.Add(1, "Who");
            mySortedList.Add(2, "Let");
            mySortedList.Add(4, "Dogs");
            mySortedList.Add(3, "The");
            mySortedList.Add(5, "Out?");

            foreach (DictionaryEntry lyric in mySortedList)
                System.Console.Write(lyric.Value + " ");

            // //dictionary doesn't allow duplicates and isn't sorted but is better for memory
            System.Console.WriteLine("\n\n[===Dictionary===]\n");
            var myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "Captain Insane-O");
            myDictionary.Add(2, "Shows");
            myDictionary.Add(4, "Mercy!");
            myDictionary.Add(3, "No");

            foreach (KeyValuePair<int, string> waterboy in myDictionary)
                System.Console.Write(waterboy.Value + " ");
            
            System.Console.WriteLine("\n\n[===Lamda Divisible by 3===]");
            var diffByThree = new List<int>();
            diffByThree.Add(5);
            diffByThree.Add(12312);
            diffByThree.Add(7);
            diffByThree.Add(9);
            diffByThree.Add(3);

            foreach (var num in diffByThree.FindAll(x => ( x % 3 ) == 0))
                System.Console.WriteLine(num);
        }
    }
}
