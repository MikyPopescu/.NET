using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelucrariStatistice
{
    public partial class Form3 : Form
    {
        List<UnitateAgricola> unitati;

        public Form3(List<UnitateAgricola> lista)
        {
            unitati = lista;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(UnitateAgricola unitate in unitati)
            {
                textBox1.Text = unitate.ToString() + Environment.NewLine;
            }
        }

        private void deschidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd();

                sr.Close();
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);

                sw.Close();
                textBox1.Clear();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dlg.Font;
            }
                
        }

     
    }
}
