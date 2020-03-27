using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_POO
{
    class Animal:ICloneable,IComparable
    {
        private string nume;
        private int varsta;
        private float greutate;

        public Animal()
        {
            nume = "n/a";
            varsta = 0;
            greutate = 0.0f;
        }

        public Animal(string num, int var, float greu)
        {
            nume = num;
            varsta = var;
            greutate = greu;
        }

        public Animal(Animal sursa)
        {
            nume = sursa.nume;
            varsta = sursa.varsta;
            greutate = sursa.greutate;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                {
                    nume = value;
                }
            }
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value >= 0)
                {
                    varsta = value;
                } }
        }

        public float Greutate
        {
            get { return greutate; }
            set { if (value >= 0)
                {
                    greutate = value;
                } }
        }

        public override string ToString()
        {
            // return base.ToString();
            return "Animalul " + nume + " are " + varsta + " ani " + "si " + greutate + " kg";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            //stabilesc relatii de ordine intre obiecte

            Animal a = (Animal)obj;
            if (this.varsta < a.varsta)
                return -1;
            else
                if (this.varsta > a.varsta)
                return 1;
            else
                return string.Compare(this.nume, a.nume);
        }
    }
}
