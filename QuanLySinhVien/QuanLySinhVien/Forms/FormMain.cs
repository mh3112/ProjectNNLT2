using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QuanLySinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListView lstView = sender as ListView;
            //ListViewItem selectedItem = lstView.SelectedItems[0];
           // ListViewItem item = lstView.SelectedItems[0];
          //  string maSV = item.SubItems[0].Name;
            // Query theo maSV lay duoc
           // SinhVien sv;

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lớnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstView.View = View.LargeIcon;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int i = 0;
          //  var s = AppDomain.CurrentDomain;
            string[] dirs = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"Images");
            foreach (string dir in dirs)
            {
                string[] sarr = dir.Split('\\');
                ListViewItem item = new ListViewItem(sarr[sarr.Length - 1], i);
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                subItem.Name = maSV.ToString();
                item.SubItems.Add("Subitem");
                lstView.Items.Add(item);
                //lstView.Items.Add(sarr[sarr.Length - 1], i);
                i++;
                if (i == imgList_Large.Images.Count - 1)
                    i = 0;
            }
        }

        private void nhỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstView.View = View.SmallIcon;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
