using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_rezolvareSub_Ionita2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Student s1 = new Student(100, "Gigi", 7.6f);
            Console.WriteLine(s1);

            //2
            Student[] studenti = new Student[3];
            studenti[0] = new Student(100, "Gigi", 7.6f);
            studenti[1] = new Student(200, "Alex", 6.4f);
            studenti[2] = new Student(90, "Dora", 9.9f);

            Array.Sort(studenti, new ComparatorNume());

            foreach(Student stud in studenti)
            {
                Console.WriteLine(stud.Nume);
            }

            Array.Sort(studenti, new ComparatorMedie());

            foreach (Student stud in studenti)
            {
                Console.WriteLine(stud.Medie);
            }
            //3
            Grupa grupa = new Grupa();
            grupa.AdaugaStudent("Ionel");
            grupa.AdaugaStudent("Purcel");
            grupa.AdaugaStudent("Martinel");
            Console.WriteLine("\nNr studenti : "+grupa.NrStudenti);
            Console.WriteLine("\nTestare index: " + grupa[1]);

            //4
            Application.Run(new Form1());
        }
    }
}
