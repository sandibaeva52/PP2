using System;
using System.IO;

namespace Ex1
{
    class FarManager 
    {
        public int cursor;
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager()
        {
            cursor = 0;
        }

        public FarManager(string path) 
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index, int i) 
        {
            if (cursor == index && cursor == i)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Show()  
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();

            for (int i = 0, k = 0; i < fs.Length; i++)  
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }



                Color(fs[i], k, i);
                Console.Write(i + 1 + ". ");
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Up() //cursor up
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down() //cursor down
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
        public void Opentxt(string path) //open text file
        {
            Console.Clear();
            StreamReader sr = new StreamReader(path); 
            string s = sr.ReadToEnd();  
            Console.WriteLine(s);  
            ConsoleKeyInfo k1 = Console.ReadKey();
            if (k1.Key == ConsoleKey.Backspace) //exit function
            {
                sr.Close();
                return;
            }
            else
                Opentxt(path);
        }
        public void CalcSz()  
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }
        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)  
            {
                CalcSz();
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up(); 
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();

                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                    else if (currentFs.Name.EndsWith(".txt")) 
                        Opentxt(currentFs.FullName);

                }
                if (consoleKey.Key == ConsoleKey.Backspace) 
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
                if (consoleKey.Key == ConsoleKey.Delete) 
                {
                    cursor = 0;
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                        Directory.Delete(currentFs.FullName, true);
                    currentFs.Delete();
                }
                if (consoleKey.Key == ConsoleKey.N)  // rename file
                {
                    string a = Console.ReadLine();
                    a = Path.Combine(directory.FullName, a);
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                        Directory.Move(currentFs.FullName, a);
                    else
                        File.Move(currentFs.FullName, a); //move file
                }


            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/PP2";
            FarManager farManager = new FarManager(path); 
            farManager.Start(); 
        }
    }
}