using System;

namespace _18Feb.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //2d arrays
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            string[] baseballTeams = { "Yankees", "Dodgers", "Giants", "Rangers", "Redsox" };
            string[,] baseballArray = new string[4, 2] { { "Angels", "White Sox" }, { "Astros", "Indians" }, { "Bluejays", "Cardinals" }, { "Nationals", "Tigers" } };
            int[,] myArray = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            Console.Write("myNumbers(foreach): ");
            foreach(int i in myNumbers)
                Console.Write(i + " ");

            Console.Write("\nbaseballTeams(foreach): ");
            Array.Sort(baseballTeams);
            foreach(string i in baseballTeams)
                Console.Write(i + " ");

            Console.Write("\nmyArray(foreach): ");
            foreach(int i in myArray)
                Console.Write(i + " ");

            Console.WriteLine("\nbaseballArray(index): ");
            Console.WriteLine(baseballArray[0, 0]);
            Console.WriteLine(baseballArray[0, 1]);
            Console.WriteLine(baseballArray[1, 0]);
            Console.WriteLine(baseballArray[1, 1]);
            Console.WriteLine(baseballArray[2, 0]);
            Console.WriteLine(baseballArray[2, 1]);
            Console.WriteLine(baseballArray[3, 0]);
            Console.WriteLine(baseballArray[3, 1]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nmyArray(for): \n");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nbaseballArray(for): \n");
            for (int i = 0; i < baseballArray.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < baseballArray.GetLength(1); j++)
                {
                    Console.Write(baseballArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            //3d array
            int[,,] threeDArray = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 } , { 10, 11, 12 } } };
            Console.WriteLine("\n3dArray(foreach): ");
            foreach(int i in threeDArray)
                Console.Write(i + " ");

            string[,,] threeDBaseball = new string[2, 2, 3] { { { "Angels", "White Sox", "Astros" }, { "Indians", "Bluejays", "Cardinals" } }, { { "Nationals", "Tigers", "Marlins" }, { "Dbacks", "Phillies", "Giants" } } };
            Console.WriteLine("\n3dBaseball: ");
            foreach(string i in threeDBaseball)
                Console.Write(i + " ");

            //jagged array
            int[][] jaggedArray =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
            };
            Console.Write("\njaggedArray: \n");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            //reverse array
            int[] arr = { 1, 2, 3, };
            string[] animals = { "Cat", "Dog", "Goat", "Horse", "Pig" };

            Console.Write("\narr: ");
            foreach(int i in arr)
                Console.Write(i + " ");
            Array.Reverse(arr);
            Console.Write("\nReverse arr : ");
            foreach (int i in arr)
                Console.Write(i + " ");

            Console.Write("\nAnimal array: ");
            foreach(string i in animals)
                Console.Write(i + " ");

            Array.Reverse(animals);
            Console.Write("\nAnimal array reversed: ");
            foreach (string i in animals)
                Console.Write(i + " ");

            //inheritance
            Console.WriteLine("\n\nInheritance: ");
            Feline cFeline = new Feline();
            Lion cLion = new Lion();
            cLion.Roar();
            cFeline.FelineHasHair();
        }
        }
    }

