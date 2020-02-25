using System;
using static System.Console;

namespace _22Jan
{
    class Program
    {
        static string Login(string userName, string pass) //Login with username and password
        {
            if (userName == "wizard" && pass == "wizard123")
            {
                ForegroundColor = ConsoleColor.Green; //Changed console color to green
                return "\nLogin Successful";
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                return "\nLogin Failed";
            }
        }
        static string Calculator(int option1) //Calculator with 5 options
        {
            switch (option1)
            {
                case 1:
                    WriteLine("Enter Your Equation");
                    var line = ReadLine();
                    var data = line.Split('+');
                    var a1 = int.Parse(data[0]);
                    var a2 = int.Parse(data[1]);
                    var a3 = int.Parse(data[2]);
                    int result = a1 + a2 + a3;
                    string total = Convert.ToString(result);
                    return "You Answer is total " + total;
                case 2:
                    WriteLine("Enter Your Equation");
                    var line2 = ReadLine();
                    var data2 = line2.Split('-');
                    var s1 = int.Parse(data2[0]);
                    var s2 = int.Parse(data2[1]);
                    var s3 = int.Parse(data2[2]);
                    int result2 = s1 - s2 - s3;
                    string total2 = Convert.ToString(result2);
                    return "You Answer is total " + total2;
                case 3:
                    WriteLine("Enter Your Equation");
                    var line3 = ReadLine();
                    var data3 = line3.Split('*');
                    var m1 = int.Parse(data3[0]);
                    var m2 = int.Parse(data3[1]);
                    var m3 = int.Parse(data3[2]);
                    int result3 = m1 * m2 * m3;
                    string total3 = Convert.ToString(result3);
                    return "You Answer is total " + total3;
                case 4:
                    WriteLine("Enter Your Equation");
                    var line4 = ReadLine();
                    var data4 = line4.Split('/');
                    var d1 = int.Parse(data4[0]);
                    var d2 = int.Parse(data4[1]);
                    var d3 = int.Parse(data4[2]);
                    int result4 = d1 / d2 / d3;
                    string total4 = Convert.ToString(result4);
                    return "You Answer is total " + total4;
                default:
                    return "Unexpected Entry";
            }
        }
        static void Main(string[] args)
        {
            //For loop exercise
            int[] myNumb = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int check = 1;
            foreach (int o in myNumb)
            {
                WriteLine(o);
                check = o;
                check = check % 2;
                if (check != 0)
                {
                    WriteLine("It's Odd and Prime");
                }
                else
                    WriteLine("It's Even");
                continue;
            }

            //For loop counting to 10
            /*for (int i = 1; i <= 10; i++)
            {
                WriteLine(i);
            }*/

            //For each loop
            /*int[] userAge = { 21, 22, 35, 65, 70 };
            foreach (int i in userAge)
            {
                WriteLine(i);
            }*/

            //For loop and Arrays
            /* for (int i = 0; i < userAge.Length; i++)
             {
                 WriteLine(i);
             }*/

            //Calculator
            /*WriteLine("------------------------");
            WriteLine("--Calculator Initiated--");
            WriteLine("------------------------");
            WriteLine("Choose an Option: \n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
            int option1 = Convert.ToInt32(ReadLine());
            WriteLine(Calculator(option1));*/

            //Login with user and pass
            /* WriteLine("[Please Login]");
             WriteLine("\n\nEnter Username:");
             string userName = ReadLine();
             WriteLine("\nEnter Password:");
             string pass = null;
             while (true)  //Loop to hide characters entered for password
             {
                 var key = ReadKey(true);
                 if (key.Key == ConsoleKey.Enter)
                     break;
                 pass += key.KeyChar;
             }
             WriteLine(Login(userName, pass));*/
        }
    }
}
