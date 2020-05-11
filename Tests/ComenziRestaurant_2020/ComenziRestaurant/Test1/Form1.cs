using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        List<Comanda> listaComenzi = new List<Comanda>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tb_cod.Text == "")
                errorProvider1.SetError(tb_cod, "Introduceti codul!");
            else if (tb_magazin.Text == "")
                errorProvider1.SetError(tb_magazin, "Introduceti magazinul!");
            else if (tb_denumire.Text == "")
                errorProvider1.SetError(tb_denumire, "Introduceti denumirea!");
            else if (tb_cantitate.Text == "")
                errorProvider1.SetError(tb_cantitate, "Introduceti cantitatea!");
            else
            {
                try
                {
                    int cod = Convert.ToInt32(tb_cod.Text);
                    string magazin = tb_magazin.Text;
                    string denumire = tb_denumire.Text;
                    double cant = Convert.ToDouble(tb_cantitate.Text);
                    Comanda c = new Comanda(cod, magazin, denumire, cant);
                    listaComenzi.Add(c);
                    MessageBox.Show("Obiect adaugat!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tb_cod.Clear();
                    tb_magazin.Clear();
                    tb_denumire.Clear();
                    tb_cantitate.Clear();
                    errorProvider1.Clear(); 

                }
            }
        }

        private void tb_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) )
                {
                          e.Handled = true;  

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2(listaComenzi);
            frm.ShowDialog(); 
        }
    }
}
