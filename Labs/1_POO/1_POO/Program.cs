using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisare la consola
            Console.WriteLine("Introduceti numele:");
            //Citire de la tastatura
            string nume = Console.ReadLine();
            //Console.WriteLine("Numele introdus este: {0}", nume);

            //declarare vector 1
            int[] v = new int[3];//pt un tip de baza, valorile default vor fi 0, altfel null
            for (int i = 0; i < v.Length; i++)
            {
               Console.Write("{0} ", v[i]);
            }
              
   
            //declarare + initalizare vector (2,3)
            int[] v1 = { 1, 2, 3, 4 };
            //int[] v1 = new int[4]{1,2,3,4};


            //shallow copy
            int[] v2 = v1; //daca schimb v2 se schimba si v1 => se lucreaza cu referinte
            v1[1] = 100; 
            for(int i = 0; i < v2.Length; i++)
            {
                Console.WriteLine(v2[i]);  //afiseaza 1 100 3 4
            }


            //deep copy
            int[] v3 = new int[v1.Length];
            for(int i = 0; i < v1.Length; i++) {
                v3[i] = v1[i];
            }
            v1[1] = 200;
            for (int i = 0; i < v3.Length; i++)
            {
               Console.WriteLine(v3[i]);
            }


            //Deep Copy C# Style
            int[] v4 = (int[])v1.Clone();
            v1[1] = 300;
            for (int i = 0; i < v4.Length; i++)
            {
               Console.WriteLine(v4[i]);
            }


            //declarare matrice 1
            int[,] m1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                      Console.Write("{0} ", m1[i, j]);
                }
                Console.WriteLine();
            }


            //declarare matrice 2
            int[][] m2 = new int[2][];
            m2[0] = new int[3] { 10, 20, 30 };
            m2[1] = new int[4] { 40, 50, 60, 70 };
            for (int i = 0; i < m2.Length; i++)
            {
                for (int j = 0; j < m2[i].Length; j++)
                    {
                         Console.Write("{0} ", m2[i][j]);
                    }
                    Console.WriteLine();
                }


            //instantiere obiecte
            Student s1 = new Student();
            Student s2 = new Student(1, "Gigel", 20, 10);
            Student s3 = new Student(s2);

            //proprietati
            s3.Nume = "Ionel";
            Console.WriteLine(s3.Nume);

            //apel metoda
            s1.afisare();
            s2.afisare();
            s3.afisare();

            Console.WriteLine(s1.ToString());
        }
    }
}
