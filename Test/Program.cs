using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int HowManyOnes(int a)
            {
                //1,2,4,8,16,32,64,128
                int count = 0;
                while (a > 0)
                {
                    if (a % 2 == 1)
                    {
                        count++;
                    }
                    a = a / 2;
                }
                return count;
            }
            int a = 1123123;
            System.Console.WriteLine(HowManyOnes(a));
        }
    }
}
