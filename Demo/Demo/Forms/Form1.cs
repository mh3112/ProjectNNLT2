using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] a = new int[15];
            string daya = "";
            int num=0;
            while (num < 15)
            {
                Random rd = new Random();
                int so = rd.Next(1, 100);
                if (!a.Contains(so))
                {
                    a[num] = so;
                    daya += so + ",";
                    num++;

                }
               
            }
            //for (int i = 0; i < 15; i++)
            //{
            //    Random rd = new Random();
            //    int num= rd.Next(1, 100);
            //    a += num;
            //    a += ",";
            //}
            textBox1.Text = daya ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
