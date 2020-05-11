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
    public partial class Form2 : Form
    {
        List<Rezervare> listaRezervari = new List<Rezervare>();
        public Form2(List<Rezervare> lista)
        {

            InitializeComponent();
            listaRezervari = lista; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Rezervare r in listaRezervari)
            {
                string result = "Cod: " + r.Cod.ToString() + "-" + "Hotel: " + r.Hotel + "-" + "Client: " + r.Client + "-" + "Pret: " + r.Pret.ToString();
                if (r.Achitat == true)
                    result += "-" + "ACHITAT";
                else
                    result += "-" + "NEACHITAT";

                treeView1.Nodes.Add(result);                
            }
        }

        private void sTERGEREToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove(); 
        }

        private void eDITAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.LabelEdit = true;
            treeView1.SelectedNode.BeginEdit(); 
        }
    }
}
