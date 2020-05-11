using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    [Serializable]
    public class Abonament
    {
        private readonly int cod;
        private string client;
        private bool activ;
        private double pret;

        public Abonament(int co,string cl, bool a, double p)
        {
            cod = co;
            client = cl;
            activ = a;
            pret = p; 
        }
        public int Cod
        {
            get { return cod;  }
            
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
        public bool Activ
        {
            get { return activ;  }
            set
            {
                activ = value; 

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
        public override string ToString()
        {
            string result =  "COD: " + cod + Environment.NewLine + "CLIENT: " + client + Environment.NewLine + "PRET: " + pret + Environment.NewLine;
            if (activ == true)
                result += "ACTIV" + Environment.NewLine;
            else
                result += "INACTIV" + Environment.NewLine;
            return result; 

        }


    }
}
