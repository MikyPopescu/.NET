using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    [Serializable]
  public class Rezervare
    {
        private readonly int cod;
        private string client;
        private string hotel;
        private double pret;
        private bool achitat;

        public Rezervare(int c, string cl, string hot, double pre,bool achi)
        {
            cod = c;
            client = cl;
            hotel = hot;
            pret = pre;
            achitat = achi; 

        }

        public int Cod
        {
            get { return cod; }
        }
        public string Client
        {
            get { return client;  }
            set
            {
                if (value != null)
                    client = value; 
            }
        }
        public string Hotel
        {
            get { return hotel; }
            set
            {
                if (value != null)
                    hotel = value;
            }
        }
        public double Pret
        {
            get { return pret;  }
            set
            {
                if (value > 0)
                    pret = value; 

            }
        }
        public bool Achitat
        {
            get { return achitat;  }
            set
            {
                
                    achitat = value;
            }
        }
        public override string ToString()
        {
           string result =  "COD: " + cod + Environment.NewLine + "CLIENT: " + client + Environment.NewLine + "HOTEL: " + hotel + Environment.NewLine + "PRET: " + pret + Environment.NewLine;
            if (achitat == true)
                result += "achitat" + Environment.NewLine;
            else
                result += "neachitat" + Environment.NewLine;
            return result; 

        }

    }
}
