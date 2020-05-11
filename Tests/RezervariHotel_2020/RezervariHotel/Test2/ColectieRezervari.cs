using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class ColectieRezervari
        
    {
        List<Rezervare> listaRezervari = new List<Rezervare>();
        public ColectieRezervari(List<Rezervare> lista)
        {
            listaRezervari = lista; 
        }
        public static ColectieRezervari operator+(ColectieRezervari c, Rezervare r)
        {
            c.listaRezervari.Add(r);
            return c; 
        }
    }
}
