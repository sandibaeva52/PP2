using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static string Space(int a)
        {
            string s = "      ";
            string q = "";
            for (int i = 0; i < a; i++)
            {
                q += s;
            }
            return q;
        }
        static void dinfo(DirectoryInfo dir, int a)
        {
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dires = dir.GetDirectories();
            foreach (FileInfo file in files)
            {

                Console.Write(Space(a));
                Console.WriteLine(file.Name);
            }
            foreach (DirectoryInfo dire in dires)
            {
                Console.Write(Space(a));
                Console.WriteLine(dire.Name);
                dinfo(dire, a + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:/Users/user/Downloads/PP2");
           dinfo(dir, 0);
            Console.ReadKey();
        }
    }
}