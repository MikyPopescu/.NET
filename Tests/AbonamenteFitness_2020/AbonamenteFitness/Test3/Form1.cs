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
    public partial class Form1 : Form
    {
        List<Abonament> listaAbonamente = new List<Abonament>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_cod.Text == "")
                errorProvider1.SetError(tb_cod, "Introduceti codul!");
            else if (tb_client.Text == "")
                errorProvider1.SetError(tb_client, "Introduceti clientul!");
            else if (tb_pret.Text == "")
                errorProvider1.SetError(tb_pret, "Introduceti pretul!");
            else if (!radioButton1.Checked && !radioButton2.Checked)
                errorProvider1.SetError(radioButton1, "Bifati starea abonamentului!");
            else
            {
                try 
                {
                    int cod = Convert.ToInt32(tb_cod.Text);
                    string client = tb_client.Text;
                    bool activ = true;
                    if (radioButton2.Checked)
                        activ = false;
                    double pret = Convert.ToDouble(tb_pret.Text);
                    Abonament a = new Abonament(cod, client, activ, pret);
                    listaAbonamente.Add(a);
                    MessageBox.Show("Abonament adaugat!"); 

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
                finally
                {
                    tb_client.Clear();
                    tb_cod.Clear();
                    tb_pret.Clear(); 
                }
            }
        }

        private void tb_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void tb_pret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&&!char.IsPunctuation(e.KeyChar) ) 
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2(listaAbonamente);
            frm.ShowDialog(); 
        }
    }
}
