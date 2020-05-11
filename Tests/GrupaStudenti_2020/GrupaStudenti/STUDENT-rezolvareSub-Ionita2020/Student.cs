using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_rezolvareSub_Ionita2020
{
    public class Student:IComparable
    {
        int cod;
        string nume;
        float medie;

        public Student() { }

        public Student(int cod, string nume, float medie)
        {
            this.cod = cod;
            this.nume = nume;
            this.medie = medie;
        }

        public int Cod { get => cod; }

        public string Nume { get => nume; set => nume = value; }

        public float Medie { get => medie; set => medie = value; }

        public override string ToString()
        {
            return "\n Cod: " + cod + "\t Nume: " + nume + "\tMedie: " + medie;
        }

       
        //pentru IComparable
        public int CompareTo(object obj)
        {
            Student stud = obj as Student;
            if(stud != null)
            {
                return this.nume.CompareTo(stud.nume);
            }
            else
            {
                throw new NullReferenceException("Error");
            }
        }
    }
}
