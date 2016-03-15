using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1TemaClassLibrary
{
    public class Controller
    {
        public Controller() { }

        public int CalculeazaGrad(int n, int m)
        {
            /* 
            Functia primeste 2 parametrii, un numar integer m si un integer n.
            Returneaza suma celor doua numere
            Complexitate O(1)
            */
            return n + m;
        }
        
        public List<int> CalculeazaPQ(List<int> p, List<int> q,int m, int n)
        {   /*
            Functia primeste doua numere intregi m si n si doua siruri de numere intregi p si q.
            Returneaza produsul celor doua siruri de numere intregi
            Complexitate: O(n^2) 
            */
            int[] v = new int[m+n+2];
            for(int i=0; i<= m+n; i++)
            {
                v[i] = 0;
            }
            
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                    v[i + j] = v[i + j] + p[i] * q[j];
            }
            List<int> lst = v.OfType<int>().ToList();
            return lst;
            
        }

        public int CalculeazaValoarea(List<int> p,List<int> q,int m, int n, int x)
        {
            /*
            Functia primeste trei numere intregi m,n si x si doua siruri de numere intrgi p si q.
            Returneaza valoarea produsului p*q in punctul x
            Complexitatea este O(n) 
            */
            List<int> v = CalculeazaPQ(p, q, m, n);
            int val = 0;
            int s = 1;
            for (int i = 0; i <= m+n; i++)
            {
                val = val + v[i] * s;
     
                s = s * x;
            }
            return val;
        }
    }
}
