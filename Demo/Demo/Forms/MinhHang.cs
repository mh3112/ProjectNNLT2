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
    public partial class MinhHang : Form
    {

        private List<int> list_numer;
        public MinhHang()
        {
            InitializeComponent();
            list_numer = new List<int>();
        }

        public void GetList()
        {
            list_numer.Clear();
            string[] s = txtInput.Text.Split(',');
            foreach (string item in s)
            {
                int t = 0;
                if (int.TryParse(item, out t))
                {
                    list_numer.Add(t);
                }
            }
        }


        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        public void setArray(ref int n, ref int[] ar)
        {
            string s = txtInput.Text;
            string[] a = s.Split(',');
            n = a.Length;
            ar = new int[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(a[i]);
            }
        }
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
        int n;
        int[] ar = new int[200];
        private void btnMax_Click(object sender, EventArgs e)
        {
            setArray(ref n, ref ar);
            string s = MaxNumber(n, ar).ToString();
            txtOutput.Text = s;

        }
        string[] arrayNumber;
        private void btnMin_Click(object sender, EventArgs e)
        {
            arrayNumber = txtInput.Text.Split(',');
            int n = arrayNumber.Length;

            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt16(arrayNumber[i]);
            }
            int b = a.Min();
            txtOutput.Text = b.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arr = txtInput.Text.Split(',');
                int[] number = new int[arr.Length];
                int index = 0;
                int sum = 0;
                foreach (string element in arr)
                {
                    //number[index] = int.Parse(element);
                    sum = sum + int.Parse(element);
                    index++;
                }
                txtOutput.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            list_numer.Clear();
            if (txtRandom.Text == "") return;
            int t = 0;
            int cout=0;

            if (int.TryParse(txtRandom.Text, out t))
            {
                txtInput.Clear();
                Random rd = new Random();
                int nb;
                do
                {
                    nb = rd.Next(0, 100);
                    if (!list_numer.Contains(nb))
                    {
                        list_numer.Add(nb);
                        cout++;
                    }
                }
                while (cout < t);

                foreach (int item in list_numer)
                {
                    txtInput.Text += item.ToString() +"," ;
                }
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1, 1);               
                // fill combobox
                cmbEdit2.Items.Clear();
                for (int i = 1; i < t+1; i++)
                {
                    cmbEdit2.Items.Add(i);
                }
            }
        }


        private void btnAsc_Click(object sender, EventArgs e)
        {
            GetList();
            list_numer.Sort();
            txtOutput.Clear();
            foreach (int item in list_numer)
            {
                txtOutput.Text += item.ToString() + ",";
            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            GetList();
            list_numer.Sort();
            list_numer.Reverse();
            txtOutput.Clear();
            foreach (int item in list_numer)
            {
                txtOutput.Text += item.ToString() + ",";
            }
        }
        public void outText(List<int> lst)
        {
            txtOutput.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                txtOutput.Text += lst[i].ToString() + ",";
            }
            txtOutput.Text.Remove(txtOutput.Text.Length-1,1);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Mình sẽ lấy chỉ số sẽ được xóa trên txt box
                int index = int.Parse(cmbEdit.Text);
                // Bước 2: Xóa phần tử ở vị trí Index
                list_numer.RemoveAt(index - 1);
                cmbEdit.Items.Clear();
                for (int i = 1; i <= list_numer.Count; i++)
                {
                    cmbEdit.Items.Add(i+1);
                }
                // Bước 2: Xóa thôi
                outText(list_numer);
                //txtOutput.Text=txtOutput.Text.Remove(index, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Còn đâu mà xóa");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtOutput.Clear();
            // buoc 1: lay chi muc duoc chon
            int index = int.Parse(cmbEdit2.Text);
            // buoc 2: xoa phan tu thu index trong output textbox
            list_numer.RemoveAt(index-1);
            // buoc 3: in danh sach da dc remove
            for (int i = 0; i < list_numer.Count; i++) {
                txtOutput.Text += list_numer[i] +",";
                txtOutput.Text.Remove(txtOutput.Text.Length-1,1);
            }
            // buoc 4 cap nhat danh sach index
            cmbEdit2.Items.Clear();
            for (int i = 1; i < list_numer.Count+1; i++)
            {
                cmbEdit2.Items.Add(i);
            }
            
        }
    }
}
