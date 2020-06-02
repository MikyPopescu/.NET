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
    public partial class Form6 : Form
    {
        int y = 10;
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //extragere continut din clipboard
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, y);
            y += 20;
            if (y > panel1.Height)
            {
                MessageBox.Show("Stop adaugare!");
                panel1.Invalidate();
                y = 10;
            }
         
        }


    }
}
