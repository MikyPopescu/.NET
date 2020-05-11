using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class ColectieAbonamente
    {
        List<Abonament> listaAbonamente = new List<Abonament>(); 
        public ColectieAbonamente(List<Abonament> lista)
        {
            listaAbonamente = lista; 
        }
        public static ColectieAbonamente operator+(ColectieAbonamente c,Abonament a)
        {
            c.listaAbonamente.Add(a);
            return c; 
        }
    }
}
