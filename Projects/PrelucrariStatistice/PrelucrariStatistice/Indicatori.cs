using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelucrariStatistice
{
   public class Indicatori:ICloneable,IComparable
    {
        public double terenArabil;
        public double vii;
        public double livezi;
        public double pasuni;


        //constructori
        public Indicatori() { }

        public Indicatori(double teren,double vi, double liv, double pas)
        {
            terenArabil = teren;
            vii = vi;
            livezi = liv;
            pasuni = pas;
        }

        //proprietati
        public double TerenArabil
        {
            get
            {
                return terenArabil;
            }
            set
            {
                if (value > 0)
                {
                    terenArabil = value;
                }
            }
        }

        public double Vii
        {
            get
            {
                return vii;
            }
            set
            {
                if (value > 0)
                {
                    vii = value;
                }
            }
        }

        public double Livezi
        {
            get
            {
                return livezi;
            }
            set
            {
                if (value > 0)
                {
                    livezi = value;
                }
            }
        }

        public double Pasuni
        {
            get
            {
                return pasuni;
            }
            set
            {
                if (value > 0)
                {
                    pasuni = value;
                }
            }
        }

        //operatori
        public static Indicatori operator +(Indicatori indicatori1, Indicatori indicatori2)
        {
            Indicatori indNou = new Indicatori();
            indNou.terenArabil = indicatori1.terenArabil + indicatori2.terenArabil;
            indNou.vii = indicatori1.vii + indicatori2.vii;
            indNou.livezi = indicatori1.livezi + indicatori2.livezi;
            indNou.pasuni = indicatori1.pasuni + indicatori2.pasuni;

            return indNou;
        }

        public static Indicatori operator -(Indicatori indicatori1, Indicatori indicatori2)
        {
            Indicatori indNou = new Indicatori();
            indNou.terenArabil = indicatori1.terenArabil - indicatori2.terenArabil;
            indNou.vii = indicatori1.vii - indicatori2.vii;
            indNou.livezi = indicatori1.livezi - indicatori2.livezi;
            indNou.pasuni = indicatori1.pasuni - indicatori2.pasuni;

            return indNou;
        }
        //metode
        public override string ToString()
        {
            return string.Format("TerenArabil: {0} ha, Vii: {1} ha, Livezi: {2} ha, Pasuni: {3} ha",
              terenArabil, vii, livezi, pasuni);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Indicatori indic = (Indicatori)obj;
            double sumaIndicatoriCurenti = TerenArabil + Vii + Livezi + Pasuni;
            double sumaAltiIndicatori = indic.TerenArabil + indic.Vii + indic.Livezi + indic.Pasuni;

            return sumaIndicatoriCurenti < sumaAltiIndicatori ? -1 : 1;
        }
    }
}
