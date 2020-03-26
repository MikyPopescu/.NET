using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_POO
{
    class Student
    {
        int cod;
        private string nume;
        public int varsta;
        protected float medie;

        //constructori
        public Student()
        {
            cod = 0;
            nume = "anonim";
            varsta = 0;
            medie = 0.0f;
        }

        public Student(int co,string num,int var,float med)
        {
            this.cod = co;
            this.nume = num;
            this.varsta = var;
            this.medie = med;
        }

        public Student(Student sursa)
        {
            cod = sursa.cod;
            nume = sursa.nume;
            varsta = sursa.varsta;
            medie = sursa.medie;
        }


        //proprietati
        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }
        
        //metoda
        public void afisare()
        {
            Console.WriteLine("Studentul {0} are codul {1}, varsta {2} si media {3}", nume, cod, varsta, medie);
        }


        public override string ToString()
        {
            //return base.ToString();
            return "Studentul " + nume + " are codul " + cod + " are varsta " + varsta + " si media" + medie;
        }
    }
}
