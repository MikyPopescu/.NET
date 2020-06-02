using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelucrariStatistice
{
   public class Adresa:ICloneable,IComparable
    {
        const string tara = "Romania";
        private string judet;
        private string strada;
        private int numar;

        //constructori
        public Adresa() { }

        public Adresa(string jud, string str, int nr)
        {
            judet = jud;
            strada = str;
            numar = nr;
        }

        //proprietati
        public string Judet
        {
            get { return judet; }
            set { if (value != null) judet = value; }
        }

        public string Strada
        {
            get { return strada; }
            set { if (value != null) strada = value; }
        }

        public int Numar
        {
            get { return numar; }
            set { if (value >= 0) numar = value; }
        }


        //metode
        public override string ToString()
        {
            return string.Format("Tara: {0}, Judet: {1}, Strada: {2}, Numar: {3}",
                   tara, judet, strada, numar);
        }


        public object Clone()
        {
            Adresa clona = (Adresa)this.MemberwiseClone();

            Adresa adresaNoua = new Adresa();

            adresaNoua.Judet = clona.Judet;
            adresaNoua.Strada = clona.Strada;
            adresaNoua.Numar = clona.Numar;

            return adresaNoua;
        }

        public int CompareTo(object obj)
        {
            Adresa adresa = (Adresa)obj;
            if (this.numar < adresa.numar)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

    }
}
