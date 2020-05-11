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
    public partial class Form1 : Form
    {
        List<Rezervare> listaRezervari = new List<Rezervare>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_cod.Text == "")
            {
                errorProvider1.SetError(tb_cod, "Introduceti codul!");
            }
            else if (tb_hotel.Text == "")
            {
                errorProvider1.SetError(tb_hotel, "Introduceti hotelul!");
            }
            else if (tb_client.Text == "")
            {
                errorProvider1.SetError(tb_client, "Introduceti numele clientului!");
            }
            else if (tb_pret.Text == "")
            {
                errorProvider1.SetError(tb_pret, "Introduceti pretul!");
            }
            else if (!radioButton1.Checked &&!radioButton2.Checked)
            {
                errorProvider1.SetError(radioButton1, "Bifati starea platii!"); 
            }
            else
            {
                try
                {
                    int cod = Convert.ToInt32(tb_cod.Text);
                    string hotel = tb_hotel.Text;
                    string client = tb_client.Text;
                    double pret = Convert.ToDouble(tb_pret.Text);
                    bool achitat = true;
                    if (radioButton2.Checked)
                        achitat = false; 
                    Rezervare r = new Rezervare(cod, client, hotel, pret,achitat);
                    listaRezervari.Add(r);
                    MessageBox.Show("Rezervare adaugata!"); 
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tb_cod.Clear();
                    tb_hotel.Clear();
                    tb_client.Clear();
                    tb_pret.Clear();
    
                    errorProvider1.Clear();
                }
            }
        }

        private void tb_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&(!char.IsControl(e.KeyChar)))
            {
                       e.Handled = true; 

            }
        }

        private void tb_pret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar)  ) 
            {
                e.Handled = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2(listaRezervari);
            frm.ShowDialog(); 
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaRezervari);
            frm.ShowDialog(); 
        }
    }
}
