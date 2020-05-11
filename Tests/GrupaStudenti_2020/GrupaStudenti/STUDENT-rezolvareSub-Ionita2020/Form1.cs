using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_rezolvareSub_Ionita2020
{
    public partial class Form1 : Form
    {
        List<Student> listaStud;

        public Form1()
        {
            InitializeComponent();

            listaStud = new List<Student>()
            {
               new Student(100, "Gigi", 7.6f),
            new Student(200, "Alex", 6.4f),
            new Student(90, "Dora", 9.9f),
            };

            AfisareStudenti();
        }

        public void AfisareStudenti()
        {
            listView1.Items.Clear();

            foreach(Student stud in listaStud)
            {
                var item = new ListViewItem(new string[]
                {
                    stud.Cod.ToString(),
                    stud.Nume,
                    stud.Medie.ToString()

                });
                item.Tag = stud;

                listView1.Items.Add(item);
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Adaugare Stduent
        //REzolvare seminar Ionita


        //Adaugare in lista doar stringuri
        //Varianta beta
        private void AddStud( int cod, string nume, float medie)
        {
            String[] row = {cod.ToString(), nume, medie.ToString()};
          
            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);

            // MessageBox.Show(tbCod.ToString()+ tbNume.ToString() +  tbMedie.ToString());
            DialogResult = DialogResult.OK;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(tbCod.Text.Length == 0)
            {
                errorProvider1.SetError(tbCod, "Completati cu un cod valid");

            }
            else
            {
                AddStud(int.Parse(tbCod.Text),
                    tbNume.Text,
                    float.Parse(tbMedie.Text));

              

                tbCod.Text = "";
                tbNume.Text = "";
                tbMedie.Text = "";
            }


            /*if(student == null)
            {
                student = new Student(
                    int.Parse(tbCod.Text),
                    tbNume.Text,
                    float.Parse(tbMedie.Text));

                listaStud.Add(student);
            }
            else
            {
                MessageBox.Show("Poate implementez si modificarea");
            }

            DialogResult = DialogResult.OK;
             */
        }
    }
}
