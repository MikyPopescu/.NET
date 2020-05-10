using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_Recap_TEST
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //double[] vectTest = new double[2];
            //vectTest[0] = 100;
            //Console.WriteLine(vectTest[0]);
            //ClientBanca c1 = new ClientBanca(100, "Popescu", "Radauti", ClientBanca.StatutJuridic.PF, 2400.24, vectTest);
            //c1.getVectorRateLunare[0] = 244.23;
            //c1.getVectorRateLunare[1] = 1000;
            //c1 += 50;
            //c1 += 40;
            //c1 += 5000.241;
            //int[] vectorSalariiM1 = { 12, 24, 200 };
            //Muncitor m1 = new Muncitor("Steve", 41, vectorSalariiM1);
            //Muncitor m2 = (Muncitor)m1.Clone();
            //m1.Nume = "Karl";
            //m1.VectorSalariuAnual[0] = 211;
            //Console.WriteLine(m1.Nume);
            //Console.WriteLine(m2.Nume);
            //Console.WriteLine("---------------------");
            //Console.WriteLine("M2 - V_SALARIU[0]: " + m2.VectorSalariuAnual[0]);
            //Console.WriteLine("M1 - V_SALARIU[0]: " + m1.VectorSalariuAnual[0]);
            //Console.WriteLine("---------------------");
            //Console.WriteLine("VIRSTE KOMBINATEH:__" + (m2 + m1));
            //Console.WriteLine("---------------------");
            //Console.WriteLine(c1.getVectorRateLunare[c1.getVectorRateLunare.Length - 1]);
            //Console.WriteLine((double)c1);
        }
    }
}
