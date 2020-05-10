using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PAW_Recap_TEST
{
    public partial class Form2 : Form
    {
        List<ClientBanca> listaCBPrivata_Form2;
        public Form2(List<ClientBanca> listaClienti)
        {
            InitializeComponent();
            foreach (ClientBanca cb in listaClienti)
            {
                tb_multiline.Text += cb.ToString() + Environment.NewLine;
            }
            listaCBPrivata_Form2 = listaClienti;
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_multiline.Clear();
            if (listaCBPrivata_Form2.Count >= 1)
            {
                listaCBPrivata_Form2.RemoveAt(listaCBPrivata_Form2.Count - 1);
            }
            foreach (ClientBanca cb in listaCBPrivata_Form2)
            {
                tb_multiline.Text += cb.ToString() + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MemoryStream memStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("ROOT");
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < listaCBPrivata_Form2.Count; i++)
                {
                    writer.WriteStartElement("Persoana" + i.ToString());

                    writer.WriteStartElement("cod");
                    writer.WriteValue(listaCBPrivata_Form2[i].getCod);
                    writer.WriteEndElement();

                    writer.WriteStartElement("nume");
                    writer.WriteValue(listaCBPrivata_Form2[i].getNume);
                    writer.WriteEndElement();

                    writer.WriteStartElement("adresa");
                    writer.WriteValue(listaCBPrivata_Form2[i].getAdresa);
                    writer.WriteEndElement();

                    writer.WriteStartElement("tip_client");
                    writer.WriteValue(listaCBPrivata_Form2[i].getTipClient.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("suma_datorata");
                    writer.WriteValue(listaCBPrivata_Form2[i].getSumaDatorata);
                    writer.WriteEndElement();

                    writer.WriteStartElement("vector_rate");
                    writer.WriteValue(listaCBPrivata_Form2[i].getVectorRateLunare.ToString());
                    writer.WriteEndElement();

                    writer.WriteEndElement();

                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                memStream.Close();
                string str = Encoding.UTF8.GetString(memStream.ToArray());
                sw.WriteLine(str);
                sw.Close();
                MessageBox.Show("All good!");
            }
        }
    }
}
