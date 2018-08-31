using System;

namespace _2
{
    class Program
    {
        class MyClass
        {

        }
        static int DaysInMonth(int month)
        {
            int days = 0;
            if (month > 0 && month < 13)
            {

                if (month == 4)
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
        static int GetValue()
        {
            return 150;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                Console.WriteLine("Enter number of month: ");
                int m = Int32.Parse(Console.ReadLine()); 
                Console.WriteLine("Days in selected month: "+DaysInMonth(m));
            }
        }
    }
}
