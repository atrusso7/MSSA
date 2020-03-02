using System;

namespace _25Feb
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism
            //Subjects m = new Subjects();
            //m.Study();
            //m = new Mathematics();
            //m.Study(); 
            #endregion

            #region Overloading
            //Overload n = new Overload();
            //Console.WriteLine("Overloading\nEnter Two Numbers: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{x} + {y} = {n.PlusMethod(x, y)}");
            #endregion

            #region 2-d array
            int[,] arr = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Console.WriteLine("2D Array: ");
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region params
            Console.WriteLine("Params: ");
            PrintIntegers(1, 2, 3, 4);
            PrintIntegers(200, 500, 600);
            PrintIntegers(777);
            static void PrintIntegers(params int[] numList)
            {
                foreach (int i in numList)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region ParamArray
            ParamArray par = new ParamArray();
            Console.WriteLine("ParamArray: ");
            Console.WriteLine(par.AddElements(1, 2, 3, 4, 5));
            Console.WriteLine();
            #endregion
        }
    }
}
