using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {

        static void Method()
        {
            int rez = 0;
            int[] nums = new int[10];

            Console.WriteLine("Input 10 numbers:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("array[{0}]:", i);
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && i < 5)
                {
                    if (i !=4)
                    {
                        rez += nums[i];
                    }
                    else
                    {
                        rez += nums[i];
                        Console.WriteLine("sum of first 5 elements:{0}", rez);
                        Console.WriteLine("/////////////////////////////");
                        break;
                    }
                }
                else
                {
                    if (i != 9)
                    {
                        if (rez == 0)//якшо rez залишити 0, на виході буде 0
                        {
                            rez = 1;
                            i = 5;
                        }
                        rez *= nums[i];
                    }
                    else
                    {
                        rez *= nums[i];
                        Console.WriteLine("product of last 5 elements:{0}", rez);
                        Console.WriteLine("/////////////////////////////");
                    }

                }
            }


        }

        static void Main(string[] args)
        {
            //Enter 10 integer numbers. Culculate the sum of first 5 elements if they are posetive or
            //product of last 5 element in  the other case.
            while (true)
            {

                Method();
            }
        }
    }
}
