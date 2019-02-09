using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//enter a string s from keyboard
            int a = int.Parse(s); // convert it to integer 

            for (int i = 0; i < a; i++) // loop for row: run till a
            {
                for (int j = 0; j <= i; j++)//loop for column: starting from 0 to i
                {
                    Console.Write("[*] "); //output this symbol

                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
