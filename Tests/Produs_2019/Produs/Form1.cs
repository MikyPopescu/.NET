using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_Recap_TEST
{
    public partial class Form1 : Form
    {
        List<ClientBanca> listaClienti;
        public Form1()
        {
            InitializeComponent();
            listaClienti = new List<ClientBanca>();
            ClientBanca cb1 = new ClientBanca(100, "Ionesque", "Adresa 1", ClientBanca.StatutJuridic.PF, 2450.58, new double[] { 10, 50, 450, 844.45 });
            ClientBanca cb2 = new ClientBanca(101, "Popesque", "Adresa 2", ClientBanca.StatutJuridic.PJ, 3000, new double[] { 10, 50, 450, 844.45 });
            ClientBanca cb3 = new ClientBanca(102, "Stroesque", "Adresa 3", ClientBanca.StatutJuridic.PF, 5000.87, new double[] { 10, 50, 450, 844.45 });
            ClientBanca cb4 = (ClientBanca)cb3.Clone();
            listaClienti.Add(cb1);
            listaClienti.Add(cb2);
            listaClienti.Add(cb3);
            //MessageBox.Show(cb4.CompareTo(cb4).ToString());
            cb4.getNume = "Vasilesque";
            cb4.getSumaDatorata = 4999.99;
        }

        private bool validareCheckBoxes()
        {
            if (cb_PF.Checked == false && cb_PJ.Checked == false)
            {
                MessageBox.Show("Trebuie sa selectezi o forma juridica!");
                return false;
            }
            else if (cb_PJ.Checked && cb_PF.Checked)
            {
                MessageBox.Show("Trebuie sa selectezi doar o forma juridica!");
                return false;
            }
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validareCheckBoxes())
            {
                if (validariGeneraleFormular())
                {
                    try
                    {
                        string[] vectorRateString = tb_vectorRate.Text.Split(',');
                        double[] vectorRate = new double[vectorRateString.Length];
                        for (int i = 0; i < vectorRateString.Length; i++)
                        {
                            vectorRate[i] = Convert.ToDouble(vectorRateString[i]);
                        }
                        listaClienti.Add(
                             new ClientBanca(
                                 Convert.ToInt32(tb_cod.Text),
                             tb_nume.Text, tb_adresa.Text,
                             cb_PF.Checked == true ? ClientBanca.StatutJuridic.PF : ClientBanca.StatutJuridic.PJ,
                             Convert.ToDouble(tb_sumaDatorata.Text),
                             vectorRate));
                        MessageBox.Show("Client adaugat cu succes!" + Environment.NewLine + listaClienti[0].ToString());
                        tb_adresa.Clear();
                        tb_cod.Clear();
                        tb_nume.Clear();
                        tb_sumaDatorata.Clear();
                        tb_vectorRate.Clear();
                        cb_PF.CheckState = CheckState.Unchecked;
                        cb_PJ.CheckState = CheckState.Unchecked;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        errProvider.Clear();
                    }
                }
            }
        }

        private bool validariGeneraleFormular()
        {
            if (tb_adresa.TextLength == 0 || tb_cod.TextLength == 0 ||
                tb_nume.TextLength == 0 || tb_sumaDatorata.TextLength == 0 || tb_vectorRate.TextLength == 0)
            {
                if (tb_adresa.TextLength == 0)
                {
                    errProvider.SetError(tb_adresa, "Introdu adresa");
                }
                if (tb_cod.TextLength == 0)
                {
                    errProvider.SetError(tb_cod, "Introdu codul");
                }
                if (tb_nume.TextLength == 0)
                {
                    errProvider.SetError(tb_nume, "Introdu numele");
                }
                if (tb_sumaDatorata.TextLength == 0)
                {
                    errProvider.SetError(tb_sumaDatorata, "Introdu suma datorata");
                }
                if (tb_vectorRate.TextLength == 0)
                {
                    errProvider.SetError(tb_vectorRate, "Introdu vector rate");
                }
                MessageBox.Show("Asigura-te ca ai introdus date in toate casutele!");
                return false;
            }
            else return true;
        }

        private void tb_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void tb_sumaDatorata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void tb_vectorRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaClienti);
            frm.Show();
        }
    }
}
