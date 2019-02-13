using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = @"C:/PP2/Week2/Task4/Task4/first.txt";
            string s2 = @"C:/PP2/Week2/Task4/Task4/second.txt";
            string a = "Just a string";
            StreamWriter sw = new StreamWriter(s1);
            sw.Write(a);
            sw.Close();
            File.Copy(s1, s2);
            File.Delete(s1);
        }
    }
}
