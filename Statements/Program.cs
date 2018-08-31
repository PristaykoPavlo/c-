using System;
using System.Collections.Generic;

namespace Statements
{

    class Program
    {

        static int DaysInMonth(int month)
        {
            int days = 0;
            if (month > 0 && month < 13)
            {
                if (month == 2)
                {
                    days = 28;
                }
                else if (month % 2 == 0)
                {
                    days = 30;
                }
                else
                {
                    days = 31;
                }
            }
            else
            {
                return 0;
            }
            return days;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Variable declaration statements.
            double area;
            double radius = 2;

            // Constant declaration statement.
            const double pi = 3.14159;

            // Expression statement (assignment).
            area = 3.14 * (radius * radius);

            // Empty statement.
            for (int i = 0; i < 10; i++)
            {
                ;
            }

            //if
            bool condition = true;

            if (condition)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }
            //while (true)
            //{
            //    Console.WriteLine("Enter number of month: ");
            //    int m = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Days in selected month: " + DaysInMonth(m));
            //}

            ////switch

            //Console.WriteLine("Do you enjoy C# ? (yes/no/maybe)");

            //string input = Console.ReadLine();

            //switch (input.ToLower())
            //{
            //    case "yes":
            //    case "maybe":
            //        Console.WriteLine(" Great!");
            //        break;
            //    case "no":
            //        Console.WriteLine("Too bad!");
            //        break;
            //}

            //while

            //for

            //for (int a = 10; a < 20; a++)
            //{
            //    if (a == 15) continue;
            //    Console.WriteLine( " value of a: {0}", a);
            //}

            //foreach

            //List<int> fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            //int count = 0;
            //foreach (int element in fibNumbers)
            //{
            //    count++;
            //    Console.WriteLine("Element #{0}:{1}",count,element);
            //}
            //Console.WriteLine($"Number of elements: {count}");

            //scope
            //bool pointB = true;
            //if (pointB == true)
            //    int radius = 5;


            Console.ReadLine();
        }
    }
}
