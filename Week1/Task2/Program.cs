using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class Student// create a new class named Student
        {
            private string name;// create parameters: name, id  year of study
            private string id;
            private int yearofstudy;
            public Student(string name, string id)//create methods
            {
                 this.name = name;
               this.id = id;
            }
            public void Increment()
            {
                yearofstudy++;
            }
            public int YearofStudy
            {
                get
                {
                  return yearofstudy;
                }
                set
                {
                 yearofstudy = value;
                }
            }


        }
        static void Main(string[] args)
        {
            Student s = new Student("Aruzhan", "18BD110550");
            s.YearofStudy = 1;
            s.Increment();
            Console.WriteLine(s.YearofStudy);
            Console.ReadKey();
        }
    }
}
