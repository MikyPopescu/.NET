using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_POO
{
    class Zebra:Animal
    {
        private bool areDungiNegre;
        private int nrPui;

        public Zebra() : base()
        {
            areDungiNegre = true;
            nrPui = 0;
        }

        public Zebra(string num, int var, float greu,int nr, bool are) : base(num, var, greu)
        {
            nrPui = nr;
            areDungiNegre = are;
        }

        public override string ToString()
        {
            return base.ToString() + " are dungi negre? " + areDungiNegre + " si are " + nrPui + " pui";
        }
    }
}
