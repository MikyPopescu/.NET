using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    [Serializable]
    public class Comanda
    {
        private readonly int cod;
        private string magazin;
        private string denumire;
        private double cantitate;

        public Comanda(int c, string m, string d, double cant)
        {
            cod = c;
            magazin = m;
            denumire = d;
            cantitate= cant;
        }
        public int Cod
        {
            get { return cod; }
        }
        public string Magazin
        {
            get { return magazin; }
            set
            {
                if (value != null)
                    magazin = value;
            }
        }
        public string Denumire
        {
            get { return denumire; }
            set
            {
                if (value != null)
                    denumire = value;
            }
        }
        public double Cantitate
        {
            get { return cantitate; }
            set
            {
                if (value > 0)
                    cantitate = value;
            }
        }
        public override string ToString()
        {
            return "COD: " + cod + Environment.NewLine + "MAGAZIN: " + magazin + Environment.NewLine + "DENUMIRE: " + denumire + Environment.NewLine + "CANTITATE: " + cantitate + Environment.NewLine; 
        }
    }
}
