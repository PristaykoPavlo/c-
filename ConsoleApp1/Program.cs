using System;

namespace ConsoleApp1
{

    class Program
    {  
        public  static int CulculateMethod(string s)
        {
            int amount=0;

            foreach (var item in s)
            { 
                switch (item)
                {
                    case 'a':
                        amount++;
                        break;
                    case 'o':
                        amount++;
                        break;
                    case 'i':
                        amount++;
                        break;
                    case 'e':
                        amount++;
                        break;

                }
            }//
            return amount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                string str = Console.ReadLine();
                Console.WriteLine(CulculateMethod(str));
            }

 
        }
    }
}
