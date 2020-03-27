using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_POO
{
    class Zoo : ICloneable
    {
        private string denumire;
        private List<Animal> animale;

        public Zoo()
        {
            denumire = "Baneasa";
            animale = new List<Animal>();
        }

        public string Denumire
        {
            get { return denumire; }
            set { if (value != null) { denumire = value; } }
        }

        public List<Animal> Animale
        {
            get { return animale; }
            set { if (value != null) { animale = value; } }
        }
        public object Clone()
        {
            Zoo clona = (Zoo)this.MemberwiseClone();
            List<Animal> copie = new List<Animal>();
            foreach (Animal animal in animale)
            {
                copie.Add((Animal)animal.Clone());
            }
             
            clona.animale = copie;

            return clona;
        }

        public Animal this[int index]
        {
            get
            {
                if(animale!=null && index>=0 && index < animale.Count)
                {
                    return animale[index];
                }
                else
                {
                    return null;
                }
            }
        }

        public override string ToString()
        {
            string rezultat = "";
            rezultat += "Zoo " + denumire + " contine urmat animale: " + Environment.NewLine;
            foreach (Animal animal in animale)
            {
                rezultat += animal.ToString() + Environment.NewLine;
            }
             
            return rezultat;
        }
    }
}
