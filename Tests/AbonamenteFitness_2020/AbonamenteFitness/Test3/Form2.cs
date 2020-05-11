using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
    public partial class Form2 : Form
    {
        List<Abonament> listaAbonamente = new List<Abonament>();
        public Form2(List<Abonament> lista)
        {
            InitializeComponent();
            listaAbonamente = lista;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Abonament a in listaAbonamente)
                listBox1.Items.Add(a); 
        }

        private void contextMenuStrip1(object sender, EventArgs e)
        {

        }

        private void sTERGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void contextMenuStrip2(object sender, EventArgs e)
        {

        }

        private void sTERGEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
