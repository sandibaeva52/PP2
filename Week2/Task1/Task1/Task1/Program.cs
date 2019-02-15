using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    class Program
    {
        public static bool Polyndrom(string s)
        {
            bool cnt = true;
            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    cnt = false;
                    return cnt;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"C:/PP2/Week2/Task1/Task1/Task1/input.txt");
            if (Polyndrom(file))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
