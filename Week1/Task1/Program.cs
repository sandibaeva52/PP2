using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool Prime(int a) //creats a new  boolean function with some integer 'a '
        {
            bool cnt = true; // a boolean variable 'cnt' which is true
            if (a <= 1) // if element 'a' is less or equals to 1
            {
                return false; // then the statement does not satisfied, false
            }
            else
            {
                for (int i = 2; i < a; i++) //else run through starting from 2 to 'a'
                {
                    if (a % i == 0) //if 'a' is divisible by 2 
                        return false;// then return false(not prime)
                }
            }
            return cnt;//else return true (prime)
        }



        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //enter a string from keyboard
            int a = int.Parse(s);  // converts the string 's' to integer and saves it as integer 'a'
            string ss = Console.ReadLine();//enter another string from keyboard
            int[] arr = new int[a]; //creates an array which has a size of  integer 'a'
            string[] sss = ss.Split(' '); //splits  every element of string 'ss' by space and saves it in a new integer 'sss'

            for (int i = 0; i < sss.Length; i++)// goes through each element ,for loop
            {
                arr[i] = int.Parse(sss[i]);// converts every element to int and add to array
            }

            List<int> b = new List<int>(); // creates a list 'b' which stores int types

            foreach (int q in arr) // use foreach loop to access each element in our array
            {
                if (Prime(q)) // if the Prime function is true 
                {
                    b.Add(q); // then add it to List 'b'
                }
            }

            Console.WriteLine(b.ToArray().Length); // output length of List 'b'

            foreach (int q in b)// for every element in List 'b'
            {
                Console.Write(q + " "); //output each element with space
            }
            Console.WriteLine();
        }
    }
}


