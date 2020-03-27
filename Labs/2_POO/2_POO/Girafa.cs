using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_POO
{
    class Girafa:Animal
    {
        private int inaltime;
        private int nrPete;

        public Girafa() : base()
        {
            inaltime = 0;
            nrPete = 0;
        }

        public Girafa(string num, int var, float greu,int inal,int nr) : base(num, var, greu)
        {
            inaltime = inal;
            nrPete = nr;
        }

        public override string ToString()
        {
            return base.ToString() + " inaltimea " + inaltime + " si nr pete" + nrPete;
        }
    }
}
