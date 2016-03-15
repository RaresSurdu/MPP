using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1TemaClassLibrary;

namespace Lab1TemaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1Input_Click(object sender, EventArgs e)
        {
            /*
           Functia primeste doua numere intregi m,n<=50 si doua siruri de numere intregi p si q.
           Returneaza produsul celor doua siruri de numere intregi
           Complexitate: O(n^2) 
           */
            try
            {
                int m = Int32.Parse(txt1Input.Text);
                string[] p = txt2Input.Text.Split(',');
                int[] pints = Array.ConvertAll(p, s => int.Parse(s));

                int n = Int32.Parse(txt3Input.Text);

                string[] q = txt4Input.Text.Split(',');
                int[] qints = Array.ConvertAll(q, s => int.Parse(s));



                //int x = Int32.Parse(txt5Input.Text);
                Controller ctr = new Controller();


                int grad_rezultat = ctr.CalculeazaGrad(n, m);

                List<int> pList = pints.OfType<int>().ToList();
                List<int> qList = qints.OfType<int>().ToList();



                List<int> sir_rezultat = ctr.CalculeazaPQ(pList, qList, m, n);
                String se = "";
                for (int i = 0; i <= m + n; i++)
                {
                    se = se + sir_rezultat[i] + " ";

                }
                
                MessageBox.Show("Grad: \n " + grad_rezultat + "Coeficientii  polinomului  p*q sunt: \n " + se);
            }
            catch
            {

                MessageBox.Show("Eroare la calcul. Va rugam verificati datele introduse", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn2Input_Click(object sender, EventArgs e)
        {
            /*
           Functia primeste trei numere intregi m,n,x<=50 si doua siruri de numere intrgi p si q.
           Returneaza valoarea produsului p*q in punctul x
           Complexitatea este O(n) 
           */
            try
            {
                int m = Int32.Parse(txt1Input.Text);
                string[] p = txt2Input.Text.Split(',');
                int[] pints = Array.ConvertAll(p, s => int.Parse(s));

                int n = Int32.Parse(txt3Input.Text);

                string[] q = txt4Input.Text.Split(',');
                int[] qints = Array.ConvertAll(q, s => int.Parse(s));



                int x = Int32.Parse(txt5Input.Text);
                Controller ctr = new Controller();


                int grad_rezultat = ctr.CalculeazaGrad(n, m);

                List<int> pList = pints.OfType<int>().ToList();
                List<int> qList = qints.OfType<int>().ToList();



                List<int> sir_rezultat = ctr.CalculeazaPQ(pList, qList, m, n);
                int val = ctr.CalculeazaValoarea(pList, qList, m, n, x);
                MessageBox.Show("Valoare polinomului este : " + Convert.ToString(val));
            }
            catch
            {

                MessageBox.Show("Eroare la calcul. Va rugam verificati datele introduse", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn3Input_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
