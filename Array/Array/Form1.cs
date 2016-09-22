using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        
        public void setArray(ref int[] ar, ref int n)
        {
            string s = txtInput.Text;
            string[] a = s.Split(',');
            n = a.Length;
            ar = new int[200];
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(a[i]);
            }
        }

        public int Sum(int n, int[] ar)
        {
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                S += ar[i];
            }
            return S;
        }

        //Tim so lon nhat
        public int MaxNumber(int n, int[] ar)
        {
            int max = ar[0];
            for (int i = 0; i < n; i++)
            {
                if (ar[i] > max)
                    max = ar[i];
            }
            return max;
        }
        //Tim so nho nhat
        public int MinNumber(int n, int[] ar)
        {
            int min = ar[0];
            for (int i = 0; i < n; i++)
            {
                if (ar[i] < min)
                    min = ar[i];
            }
            return min;
        }
        //Sap xep day tang dan
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void AscSort(int n, ref int[] ar)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] > ar[j])
                        Swap(ref ar[i], ref ar[j]);
                }
            }
        }

        public void DesSort(int n, ref int[] ar)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] < ar[j])
                        Swap(ref ar[i], ref ar[j]);
                }
            }
        }

        int[] ar = new int[200];
        int n = 0;
        
        private void btnMax_Click(object sender, EventArgs e)
        {
            /*int[] ar = new int[200];
            int n = 0;*/
            setArray(ref ar, ref n);
            string s = MaxNumber(n, ar).ToString();
            txtOutput.Text = s;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
           /* int[] ar = new int[200];
            int n = 0;*/
            setArray(ref ar, ref n);
            string s = MinNumber(n, ar).ToString();
            txtOutput.Text = s;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            setArray(ref ar, ref n);
            string s = Sum(n, ar).ToString();
            txtOutput.Text = s;
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            setArray(ref ar,ref n);
            AscSort(n, ref ar);
            string[] s=new string[200];
            string str = ""; 
            for (int i = 0; i < n; i++)
            {
                s[i] = ar[i].ToString();
                str += s[i] + ',';
            }
            str = str.Remove(str.Length - 1, 1);
            txtInput.Text = str;
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            setArray(ref ar, ref n);
            DesSort(n, ref ar);
            
            string[] s = new string[200];
            string str = ""; 
            for (int i = 0; i < n; i++)
            {
                s[i] = ar[i].ToString();
                str += s[i] + ',';
            }
            str = str.Remove(str.Length - 1, 1);
            txtInput.Text = str;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtRandom.Text);
            Random rd = new Random();
            int[] a = new int[200];
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(0, n);
            }
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += a[i].ToString() + ',';
            }
             s = s.Remove(s.Length-1,1);
            txtInput.Text = s;
        }

        private void cmbEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = int.Parse(cmbEdit.Text);
            txtInput.Text = txtInput.Text.Remove(index-1, 1);
        }
    }
}
