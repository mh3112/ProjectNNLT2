using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Demo.UC;

namespace Demo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // 1 dong 1
        /*
         * dong1
         * dong 2
         * dong 3
         */

        public int tong2So(int a, int b)
        {
            return a + b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int tong = 0;
            tong = tong2So(a, b);

            ucNhanVien nhanVien = new ucNhanVien();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(nhanVien);
            nhanVien.Dock = DockStyle.Fill;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ucMain main = new ucMain();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(main);
            main.Dock = DockStyle.Fill;
        }
    }
}
