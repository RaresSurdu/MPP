using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab1TemaClassLibrary;

namespace ps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[20];
            int[] p = new int[20];
            int[] q = new int[20];
            int n, m;
            Console.WriteLine("Dati gradul polinomului P: n= ");

                n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Dati coeficientii polinomului P");
            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine("Coeficientul " + i + ":");
                p[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Dati gradul polinomului Q: m= ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dati coeficientii polinomului Q");

            for (int i = m; i >= 0; i--)
            {
                Console.WriteLine("Coeficientul " + i + ":");
                q[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Dati valoarea lui x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Controller ctr = new Controller();
            int grad_rezultat = ctr.CalculeazaGrad(n, m);
            List<int> pList = p.OfType<int>().ToList();
            List<int> qList = q.OfType<int>().ToList();


            List<int> sir_rezultat = ctr.CalculeazaPQ(pList, qList,m,n);
            int val = ctr.CalculeazaValoarea(pList,qList,m,n,x);

            Console.WriteLine("Rezultate:");
            Console.WriteLine("Grad rez: "+grad_rezultat);
            Console.WriteLine("Sir:");
            String s = "";
            for (int i = 0; i <=m+n; i++)
            {
                s = s + sir_rezultat[i] + " ";
               
            }
            Console.WriteLine(s);
            Console.WriteLine("Val:");
            Console.WriteLine(val);


        
            Console.ReadLine();
        }
    }
}
