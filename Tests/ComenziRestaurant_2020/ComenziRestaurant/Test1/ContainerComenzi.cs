using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class ContainerComenzi
    {
        private List<Comanda> listaComenzi = new List<Comanda>(); 
        public ContainerComenzi (List<Comanda> lista)
        {
            foreach (Comanda c in lista)
                listaComenzi.Add(c); 
        }

        public static ContainerComenzi operator+(ContainerComenzi container, Comanda c)
        {
            container.listaComenzi.Add(c);
            return container; 
        }
    }
}
