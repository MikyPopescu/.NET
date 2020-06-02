using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelucrariStatistice
{
    public partial class Form4 : Form
    {
        string connString;

        public Form4()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Unitati.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //MessageBox.Show("Merge");
                OleDbCommand comanda = new OleDbCommand("SELECT * FROM Unitati", conexiune);


                OleDbDataReader reader = comanda.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["Denumire"].ToString());
                    itm.SubItems.Add(reader["Judet"].ToString());
                    itm.SubItems.Add(reader["Strada"].ToString());
                    itm.SubItems.Add(reader["Numar"].ToString());
                    itm.SubItems.Add(reader["TerenArabil"].ToString());
                    itm.SubItems.Add(reader["Vii"].ToString());
                    itm.SubItems.Add(reader["Livezi"].ToString());
                    itm.SubItems.Add(reader["Pasuni"].ToString());

                    listView1.Items.Add(itm);

                }
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
