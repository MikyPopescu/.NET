using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form2 : Form
    {
        List<Comanda> listaComenzi = new List<Comanda>();
        public Form2(List<Comanda> lista)
        {
        
            InitializeComponent();
            listaComenzi = lista;
            foreach (Comanda c in lista)

            {
                ListViewItem item = new ListViewItem(c.Cod.ToString());
                item.SubItems.Add(c.Magazin);
                item.SubItems.Add(c.Denumire);
                item.SubItems.Add(c.Cantitate.ToString());
                listView1.Items.Add(item);
            }
                
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sTERGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                /* try 
                 { listaComenzi.RemoveAt(listView1.SelectedIndices[0]); }
                 catch(Exception ex)
                 {
                     MessageBox.Show(ex.Message); 
                 }*/
                foreach (ListViewItem itm in listView1.Items)

                    if (itm.Selected)
                    {
                        listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "(*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)

            {

                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlg.FileName);
                foreach (Comanda c in listaComenzi)

                    
                    {
                    sw.WriteLine(c.ToString());

                    }
               

                sw.Close();

                listView1.Clear();

            }
        }
    }
}
