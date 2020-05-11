using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form3 : Form
    {
        List<Rezervare> listaRezervari = new List<Rezervare>();
        public Form3(List<Rezervare> lista)
        {
            InitializeComponent();
            listaRezervari = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
                int achitate = 0;
                int neachitate = 0;
                foreach (Rezervare b in listaRezervari)
                {
                    if (b.Achitat == true)
                     { achitate++; }
                    else
                        neachitate++; 
                }
            this.chart1.Series["A"].Points.AddXY("", achitate);
            this.chart1.Series["N"].Points.AddXY("", neachitate);



        }
    }
}
