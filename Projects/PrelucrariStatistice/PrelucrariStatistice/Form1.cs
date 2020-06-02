using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelucrariStatistice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaUnitateAgricola_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btnBd_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();

        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

        private void btnDragDrop_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }
    }
}
