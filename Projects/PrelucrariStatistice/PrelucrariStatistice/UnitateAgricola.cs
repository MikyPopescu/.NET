using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelucrariStatistice
{
    [Serializable]
    public class UnitateAgricola: IComparable<UnitateAgricola>, ICloneable
    {
        public int id;
        public string denumire;
        public Adresa adresa = new Adresa();
        public Indicatori indicatori = new Indicatori();


        public UnitateAgricola()
        {
            denumire = "n/a";
            adresa.Judet = "n/a";
            adresa.Strada = "n/a";
        }

        public UnitateAgricola(int i,string den, Adresa adr, Indicatori indic)
        {
            id = i;
            denumire = den;
            adresa = adr;
            indicatori = indic;
        }

        public override string ToString()
        {
            return string.Format("Denumire Unitate: {0} Cod identificare: {1} Adresa:\n{2}\nIndicatorii colectati:\n{3}",
               denumire, id, adresa, indicatori);
        }

        public int CompareTo(UnitateAgricola other)
        {
            return indicatori.CompareTo(other.indicatori);
        }

        public object Clone()
        {
            UnitateAgricola clona = (UnitateAgricola)this.MemberwiseClone();

            Adresa adresa = new Adresa();
            adresa = (Adresa)adresa.Clone();

            Indicatori indicatori = new Indicatori();
            indicatori = (Indicatori)indicatori.Clone();

            clona.adresa = adresa;
            clona.indicatori = indicatori;

            return clona;
        }
    }
}
