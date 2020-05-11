using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_rezolvareSub_Ionita2020
{
    class Grupa
    {
        List<Student> listaStud = new List<Student>();

        public void AdaugaStudent(String nume)
        {
            int cod;
            float medie=0;
            if (listaStud == null)
            {
                cod = 1;
            }
            else
            {
                cod = listaStud.Count + 1;
            }
            Student student = new Student(cod,nume, medie);
            listaStud.Add(student);

        }

        public int NrStudenti
        {
            get
            {
                return listaStud.Count();
            }
        }

        public Student this[int index]
        {
            get
            {
                if(index < NrStudenti)
                {
                    return listaStud[index];
                }
                else
                {
                    return new Student(404, "Anonnim", 0);
                }
            }
        }
    }
}
