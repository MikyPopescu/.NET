using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PrelucrariStatistice
{

    public partial class Form5 : Form
    {
        double[] valori = new double[20];
        int nrElem = 0;
        bool ok = false;
        const int margine = 10;
        Color culoare = Color.Red;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        public Form5()
        {
            InitializeComponent();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("suprafete.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    valori[nrElem] = Convert.ToDouble(linie);
                    nrElem++;
                    ok = true; //am cel putin un element in vector
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Date incarcate");
            //  Invalidate(); //declansare paint
            panel1.Invalidate();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            if (ok == true)
            {
                Graphics g = e.Graphics;
             

                Rectangle rect = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + margine,
                    panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 2 * margine);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3;
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1);
                double vMax = valori.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rect.Location.Y + rect.Height - valori[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(valori[i] / vMax * rect.Height));
                    g.DrawString(valori[i].ToString(), font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - font.Height)));
                }

                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }

          
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                culoare = dlg.Color;
            }
            // Invalidate();
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                font = dlg.Font;
            }
            panel1.Invalidate();
          //  Invalidate();
        }

        private void save(Control control, string denumire)
        {
            Bitmap img = new Bitmap(control.Width,control.Height);
            control.DrawToBitmap(img, new Rectangle(control.ClientRectangle.X, control.ClientRectangle.Y, control.ClientRectangle.Width, control.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(panel1, "poza.png");
            MessageBox.Show("S-a salvat");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (ok == true)
            {
                Graphics g = e.Graphics;
           
                Rectangle rect = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + margine,
                    panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 2 * margine);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3;
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1);
                double vMax = valori.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rect.Location.Y + rect.Height - valori[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(valori[i] / vMax * rect.Height));
                    g.DrawString(valori[i].ToString(), font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - font.Height)));
                }

                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }
        }


        private void pd_print(object sender, PrintPageEventArgs e)
        {
            if (ok == true)
            {
                Graphics g = e.Graphics;

                Rectangle rect = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 2 * margine,
                    e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 3 * margine);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3;
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1);
                double vMax = valori.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rect.Location.Y + rect.Height - valori[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(valori[i] / vMax * rect.Height));
                    g.DrawString(valori[i].ToString(), font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - font.Height)));
                }

                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }
        }


        private void previzualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
