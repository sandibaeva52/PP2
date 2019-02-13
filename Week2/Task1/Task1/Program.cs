using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string reverse = "";
            for (int i=s.Length-1;i>=0;i--)
            {
                reverse += s[i].ToString();
            }
            if (reverse==s)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
            Console.ReadLine();
        }
    }
}
