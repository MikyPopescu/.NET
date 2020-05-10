using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Recap_TEST
{
    class Muncitor : ICloneable
    {
        string nume;
        int varsta;
        int[] vectorSalariuAnual;


        public Muncitor(string n, int v, int[] vsAnual)
        {
            nume = n;
            varsta = v;
            vectorSalariuAnual = vsAnual;
        }

        public object Clone()
        {
            Muncitor m = (Muncitor)this.MemberwiseClone();
            m.vectorSalariuAnual = (int[])this.vectorSalariuAnual.Clone();
            return m;
        }


        public string Nume
        {
            get { return this.nume; }
            set { if (value.Length > 0) this.nume = value; }
        }

        public int[] VectorSalariuAnual { get { return this.vectorSalariuAnual; } }

        public int this[int index]
        {
            get { return vectorSalariuAnual[index]; }
            set { if (index < vectorSalariuAnual.Length) vectorSalariuAnual[index] = value; }
        }

        public int Varsta { get; set; }
        public static int operator +(Muncitor m1, Muncitor m2) => m1.varsta + m2.varsta;


    }
}
