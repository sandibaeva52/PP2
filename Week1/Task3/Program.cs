using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s); //convert string to int and save it in 'a'
            string ss = Console.ReadLine();//input new string for elements
            string[] sss = ss.Split(' ');//splitting elements by space and saving to a new string array sss

            for (int i = 0; i < a; i++) //for loop to go through each element
            {
                int k = int.Parse(sss[i]);//convert elements to int and save it to int k

                for (int j = 0; j < 2; j++) //new for loop to repeat the elements twice
                {
                    Console.Write(k + " "); // output elements with space
                }


            }
        }
    }
}
