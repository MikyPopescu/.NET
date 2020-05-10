using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Recap_TEST
{
    [Serializable]
    public class ClientBanca : Client, ICloneable, IComparable, IMedia
    {
        StatutJuridic tipClient;
        double sumaDatorata;
        double[] vectorRateLunare;

        public ClientBanca(int c, string n, string adr, StatutJuridic tip, double sDatorata, double[] vectorRLunare) : base(c, n, adr)
        {
            tipClient = tip;
            sumaDatorata = sDatorata;
            vectorRateLunare = vectorRLunare;
        }

        static ClientBanca()
        {
        }

        public object Clone()
        {
            ClientBanca clientClonat = (ClientBanca)this.MemberwiseClone();
            clientClonat.vectorRateLunare = (double[])this.vectorRateLunare.Clone();
            return clientClonat;
        }

        public int CompareTo(object obj)
        {
            if (this.tipClient == StatutJuridic.PF && ((ClientBanca)obj).getTipClient == StatutJuridic.PJ)
            {
                return 1;
            }
            else if (((ClientBanca)obj).getTipClient == StatutJuridic.PF)
            {
                return this.getSumaDatorata.CompareTo(((ClientBanca)obj).getSumaDatorata);
            }
            else return 0;
        }

        public StatutJuridic getTipClient
        {
            get { return this.tipClient; }
            set
            {
                if (tipClient is StatutJuridic.PJ || tipClient is StatutJuridic.PF)
                {
                    tipClient = value;
                };
            }
        }

        public double getSumaDatorata
        {
            get
            {
                return this.sumaDatorata;
            }
            set
            {
                if (value > 0)
                {
                    this.sumaDatorata = value;
                }
            }
        }

        public double[] getVectorRateLunare
        {
            get { return this.vectorRateLunare; }
            set { if (value.Length > 0) this.vectorRateLunare = value; }
        }

        public static ClientBanca operator +(ClientBanca cb, double valoare)
        {
            double[] vectorNou = new double[cb.getVectorRateLunare.Length + 1];
            for (int i = 0; i < cb.getVectorRateLunare.Length; i++)
            {
                vectorNou[i] = cb.getVectorRateLunare[i];
            }
            vectorNou[vectorNou.Length - 1] = valoare;
            cb.getVectorRateLunare = vectorNou;
            return cb;
        }

        public static explicit operator double(ClientBanca cb)
        {
            double medie = 0;
            for (int i = 0; i < cb.getVectorRateLunare.Length; i++)
            {
                medie += cb.getVectorRateLunare[i];
            }
            return medie / cb.getVectorRateLunare.Length;
        }

        public override string ToString()
        {
            return "Clientul cu codul " + getCod + " are o datorie de " + getSumaDatorata + " lei.";
        }

        public double CalculeazaValoareMediePlatita()
        {
            double medie = 0;
            for (int i = 0; i < this.getVectorRateLunare.Length; i++)
            {
                medie += this.getVectorRateLunare[i];
            }
            return medie / this.getVectorRateLunare.Length;
        }

        public enum StatutJuridic
        {
            PF, PJ
        }
    }
}
