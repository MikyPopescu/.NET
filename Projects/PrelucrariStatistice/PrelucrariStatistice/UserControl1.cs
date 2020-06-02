using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PrelucrariStatistice
{
    public partial class UserControl1 : UserControl
    {
        //fisierul se gaseste in bin debug, calea trebuie schimbata
        string CaleFisier = @"D:\Projects\Git\WindowsApplicationProgramming\Projects\PrelucrariStatistice\PrelucrariStatistice\bin\Debug\judete.txt";
        public ComboBox cb = new ComboBox();

        public UserControl1()
        {
            InitializeComponent();
            PuneDateInComboBox();
            cb = comboBox1;
        }

        public string ReturnJudetSelectat()
        {
            string aa = string.Empty;
            if (comboBox1.SelectedItem == null)
                return string.Empty;
            else
            {
                aa = comboBox1.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(aa))
                    return string.Format(aa);
                else
                    return string.Empty;
            }
        }

        public List<string> InstantiazaListaJudete()
        {
            List<string> judete = new List<string>();

            string[] linii = File.ReadAllLines(CaleFisier);
            for (int i = 0; i < 42; i++)
            {
                judete.Add(linii[i]);
            }

            return judete;
        }

        private void PuneDateInComboBox()
        {
            List<string> judete = InstantiazaListaJudete();
            foreach (var judet in judete)
                comboBox1.Items.Add(judet);
        }
    }
}
