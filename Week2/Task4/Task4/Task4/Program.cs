using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = @"C:\PP2\Week2\Task4\Task4\first.txt"; // file path
            string s2 = @"C:\PP2\Week2\Task4\Task4\second.txt";    
            string s = "Just some string";
            StreamWriter sw = new StreamWriter(s1);
            sw.Write(s);
            sw.Close();
            File.Copy(s1, s2);//copy text from first to second
            File.Delete(s1);//delete first file
        }
    }
}