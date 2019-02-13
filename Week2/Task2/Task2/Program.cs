using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static bool prime(int b)
        {
            bool cnt = true;
            if (b <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < b; i++)
                {
                    if (b % i == 0)
                        return false;
                }
            }
            return cnt;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:/PP2/Week2/Task2/Task2/text.txt");
            string arr = sr.ReadToEnd();
            string[] arr2 = arr.Split(' ');
            StreamWriter sw = new StreamWriter(@"C:/PP2/Week2/Task2/Task2/output.txt");
            for (int i = 0; i < arr2.Length; i++)
            {
                int a = int.Parse(arr2[i]);
                if (prime(a))
                {
                    sw.Write(a + " ");
                }

            }
            
        }
    }
   
}
 
