using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrelucrariStatistice
{
    public partial class Form2 : Form
          
    
    {
        List<UnitateAgricola> listaUnitati = new List<UnitateAgricola>();
        string connString;
        public Form2()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Unitati.accdb";
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                String denumire = tbDenumire.Text;
                String judet = Convert.ToString(ucJudet.Text);
                String strada = tbStrada.Text;
                int numar = Convert.ToInt32(tbNumar.Text);
                double terenArabil = Convert.ToDouble(tbTeren.Text);
                double vii = Convert.ToDouble(tbVii.Text);
                double livezi = Convert.ToDouble(tbLivezi.Text);
                double pasuni = Convert.ToDouble(tbPasuni.Text);

                Adresa adresa = new Adresa(judet, strada, numar);
                Indicatori indicator = new Indicatori(terenArabil, vii, livezi, pasuni);
                UnitateAgricola unitate = new UnitateAgricola(cod,denumire, adresa, indicator);
                MessageBox.Show(unitate.ToString());
                listaUnitati.Add(unitate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbDenumire.Clear();
                ucJudet.ResetText();
                tbStrada.Clear();
                tbNumar.Clear();
                tbTeren.Clear();
                tbVii.Clear();
                tbLivezi.Clear();
                tbPasuni.Clear();

            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaUnitati);
            frm.Show();
        }

        //validare pentru denumire 
        private void tbDenumire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        //pentru strada
        private void tbStrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        //pentru indicatori si numar
        private void tbNumar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tb suporta doar cifre
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnStocare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(ID) FROM Unitati";
                int id = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO Unitati VALUES(?, ?, ?, ?, ?,?,?,?,?)";
               

                comanda.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(tbCod.Text);
                comanda.Parameters.Add("Denumire", OleDbType.Char, 40).Value = tbDenumire.Text;
                comanda.Parameters.Add("Judet", OleDbType.Char, 50).Value = Convert.ToString(ucJudet.Text);
                comanda.Parameters.Add("Strada", OleDbType.Char, 40).Value = tbStrada.Text;
                comanda.Parameters.Add("Numar", OleDbType.Integer).Value = Convert.ToInt32(tbNumar.Text);
                comanda.Parameters.Add("TerenArabil", OleDbType.Integer).Value = Convert.ToDouble(tbTeren.Text);
                comanda.Parameters.Add("Vii", OleDbType.Integer).Value = Convert.ToDouble(tbVii.Text);
                comanda.Parameters.Add("Livezi", OleDbType.Integer).Value = Convert.ToDouble(tbLivezi.Text);
                comanda.Parameters.Add("Pasuni", OleDbType.Integer).Value = Convert.ToDouble(tbPasuni.Text);

                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbCod.Clear();
                tbDenumire.Clear();
                ucJudet.ResetText();
                tbStrada.Clear();
                tbNumar.Clear();
                tbTeren.Clear();
                tbVii.Clear();
                tbLivezi.Clear();
                tbPasuni.Clear();
            }
        }

        private void btnBd_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
