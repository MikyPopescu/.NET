using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Recap_TEST
{
    public abstract class Client
    {
        private readonly int cod;
        private string nume;
        private string adresa;

        public Client(int c, string n, string adr)
        {
            cod = c;
            nume = n;
            adresa = adr;
        }

        public int getCod
        {
            get { return this.cod; }
        }

        public string getNume
        {
            get { return this.nume; }
            set { if (value.Length > 0) this.nume = value; }
        }
        public string getAdresa
        {
            get { return this.adresa; }
            set { if (value.Length > 0) this.adresa = value; }
        }
    }
}
