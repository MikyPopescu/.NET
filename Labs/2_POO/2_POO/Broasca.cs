using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_POO
{
    class Broasca:Animal
    {
        private string culoare;
        private bool esteTestoasa;

        public Broasca() : base()
        {
            culoare = "verde";
            esteTestoasa = true;
        }

        public Broasca(string num, int var, float greu,string cul, bool este) : base(num, var, greu)
        {
            culoare = cul;
            esteTestoasa = este;
        }
        public override string ToString()
        {
            return base.ToString() + " si are culoarea " + culoare + " Este testoasa? " + esteTestoasa;
        }
    }
}
