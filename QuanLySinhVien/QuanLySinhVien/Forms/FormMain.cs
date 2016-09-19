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
using BL;

namespace QuanLySinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void LoadToDTgrid()
        {

        }

        List<SinhVien> dsSV = new List<SinhVien>();
        string tool = "";
        /// <summary>
        /// Doc file va dua len Gridview
        /// </summary>
        /// <param name="path"></param>
        public void GetAllStudent(string path)
        {
            StreamReader reader = null;
            reader = File.OpenText("danhsach.txt");
            List<SinhVien> list = new List<SinhVien>();
            string str;
            while ((str = reader.ReadLine()) != null)
            {
                string[] st = str.Split('|');
                SinhVien sv = new SinhVien(st[0], st[1], st[2], st[3], st[4], st[5], st[6], st[7]);
                dsSV.Add(sv);
            }
            reader.Close();
            foreach (SinhVien sv in dsSV)
            {
                dataGridView.Rows.Add(sv.MaSV, sv.HoTen, sv.Lop, sv.NgaySinh, sv.GioiTinh, sv.QueQuan, sv.DiemTB, sv.NguoiYeu);
            }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListView lstView = sender as ListView;
            //ListViewItem item = lstView.SelectedItems[0];
            //string id = item.SubItems[0].Name;
            // Query theo maSV lay duoc
            
            //MessageBox.Show(id);


        }
       
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            tSB_Luu.Enabled = false;
            tSB_Thoat.Enabled = false;
            //Load image len listview 
            int i = 0;
            string[] dirs = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"Images");
            foreach (string dir in dirs)
            {
                string[] str = dir.Split('\\');
                ListViewItem item = new ListViewItem(str[str.Length - 1], i);
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                //subItem.Name = maSV.ToString();
                item.SubItems.Add("");
                lstView.Items.Add(item);
                //lstView.Items.Add(sarr[sarr.Length - 1], i);
                //   lstView.Items.Add(dir, i);
                i++;
                if (i == imgList_Large.Images.Count)
                    i = 0;
            }

            //Dua du lieu len grid
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            GetAllStudent("");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id của dòng đang chọn
            //MessageBox.Show(dataGridView.CurrentRow.Index.ToString());
            //Cách 1 truy cập từng cell giá trị và gán lên 
            try
            {

                if (dataGridView.CurrentRow.Cells["maSV"].Value != null)
                {
                    txtMaSV.Text = dataGridView.CurrentRow.Cells["maSV"].Value.ToString();
                    txtTen.Text = dataGridView.CurrentRow.Cells["hoTen"].Value.ToString();
                    txtQue.Text = dataGridView.CurrentRow.Cells["queQuan"].Value.ToString();
                    txtLop.Text = dataGridView.CurrentRow.Cells["lop"].Value.ToString();
                    txtDiem.Text = dataGridView.CurrentRow.Cells["diemTB"].Value.ToString();
                    dateTime.Value = DateTime.Parse(dataGridView.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    //Gioi tinh
                    string GT = dataGridView.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nu")
                        rdbNu.Checked = true;
                    //Nguoi yeu
                    string ny = dataGridView.CurrentRow.Cells["nguoiYeu"].Value.ToString();
                    if (ny == "Co")
                    {
                        chk_Co.Checked = true;
                        chk_Khong.Checked = false;
                    }
                    if (ny == "Khong")
                    {
                        chk_Co.Checked = false;
                        chk_Khong.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Thiết lập lại trạng thái ban đầu
        /// </summary>
        public void Reset()
        {
            txtMaSV.Clear();
            txtDiem.Clear();
            txtQue.Clear();
            txtTen.Clear();
            txtLop.Clear();
            chk_Co.Checked = false;
            chk_Khong.Checked = false;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
        }

        public void WriteToFile(List<SinhVien> list)
        {
            // StreamWriter write = new StreamWriter(fs, System.Text.Encoding.UTF8);
            // StreamWriter write = new StreamWriter("SV.txt",true);

            FileStream fs = new FileStream("danhsach.txt", FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter write = new StreamWriter(fs);
            foreach (SinhVien newSV in list)
            {
                //insertAStudent(sv);
                string s = newSV.MaSV + "|" + newSV.HoTen + "|" + newSV.Lop + "|" + newSV.NgaySinh + "|" + newSV.GioiTinh + "|" + newSV.QueQuan + "|" + newSV.DiemTB + "|" + newSV.NguoiYeu;
                write.WriteLine(s);
            }
            write.Close();
        }
    /*    public void InsertAStudent(SinhVien newSV)
        {
            //Ham ghi file
            StreamWriter write = new StreamWriter("danhsach.txt", false);
            string s = newSV.MaSV + "|" + newSV.HoTen + "|" + newSV.Lop + "|" + newSV.NgaySinh + "|" + newSV.GioiTinh + "|" + newSV.QueQuan + "|" + newSV.DiemTB + "|" + newSV.NguoiYeu;
            write.WriteLine(s);
            write.Close();
        }*/

        public void DeleteAStudent()
        {

            // int index = dsSV.FindIndex(x => x.MaSV == txtMaSV.Text);
            // if (index != -1)
            dsSV.RemoveAt(dsSV.FindIndex(x => x.MaSV == txtMaSV.Text));
            WriteToFile(dsSV);
        }
        // Tool Sửa
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tool = "Sua";
            txtMaSV.Enabled = false;
            tSB_Capnhat.Enabled = false;
            tSB_Sua.Enabled = false;
            tSB_Them.Enabled = false;
            tSB_Luu.Enabled = true;
            tSB_Thoat.Enabled = true;

        }

        private void toolSB_Them_Click(object sender, EventArgs e)
        {
            tool = "Them";
            tSB_Them.Enabled = false;
            tSB_Sua.Enabled = false;
            tSB_Xoa.Enabled = false;
            tSB_Capnhat.Enabled = false;
            tSB_Luu.Enabled = true;
            tSB_Thoat.Enabled = true;
            Reset();
        }

        private void toolSB_Luu_Click(object sender, EventArgs e)
        {
            if (tool == "Them")
            {
                string id = txtMaSV.Text;
                bool check = true;
                foreach (SinhVien sv in dsSV)
                {
                    if (id == sv.MaSV || id==null)
                        check = false;
                }
                if (check == false)
                {
                    MessageBox.Show("Mã Sinh Viên không hợp lệ. Vui lòng nhập lại");
                    Reset();
                }
                else
                {
                    string name = txtTen.Text;
                    string class_ = txtLop.Text;
                    string date = dateTime.Value.ToString();
                    string count = txtQue.Text;
                    string score = txtDiem.Text;
                    string love;
                    if (chk_Co.Checked == true)
                        love = "Co";
                    else
                        love = "Khong";
                    string sex;
                    if (rdbNam.Checked == true)
                        sex = "Nam";
                    else
                        sex = "Nu";
                    SinhVien newSV = new SinhVien(id, name, class_, date, sex, count, score, love);
                    StreamWriter write = new StreamWriter("danhsach.txt", true);
                    string s = newSV.MaSV + "|" + newSV.HoTen + "|" + newSV.Lop + "|" + newSV.NgaySinh + "|" + newSV.GioiTinh + "|" + newSV.QueQuan + "|" + newSV.DiemTB + "|" + newSV.NguoiYeu;
                    write.WriteLine(s);
                    write.Close();
                    dataGridView.Rows.Clear();
                    dsSV.Clear();
                    GetAllStudent("");
                }

            }
            if (tool == "Sua")
            {
                DeleteAStudent();
                string id = txtMaSV.Text;
                string name = txtTen.Text;
                string class_ = txtLop.Text;
                string date = dateTime.Value.ToString();
                string count = txtQue.Text;
                string score = txtDiem.Text;
                string love;
                if (chk_Co.Checked == true)
                    love = "Co";
                else
                    love = "Khong";
                string sex;
                if (rdbNam.Checked == true)
                    sex = "Nam";
                else
                    sex = "Nu";
                SinhVien newSV = new SinhVien(id, name, class_, date, sex, count, score, love);
                StreamWriter write = new StreamWriter("danhsach.txt", true);
                string s = newSV.MaSV + "|" + newSV.HoTen + "|" + newSV.Lop + "|" + newSV.NgaySinh + "|" + newSV.GioiTinh + "|" + newSV.QueQuan + "|" + newSV.DiemTB + "|" + newSV.NguoiYeu;
                write.WriteLine(s);
                write.Close();
                dataGridView.Rows.Clear();
                dsSV.Clear();
                GetAllStudent("");
                txtMaSV.Enabled = true;
            }
            tSB_Them.Enabled = true;
            tSB_Sua.Enabled = true;
            tSB_Xoa.Enabled = true;
            tSB_Capnhat.Enabled = true;
            tSB_Luu.Enabled = false;
            tSB_Thoat.Enabled = false;
            tool = "";
        }

        private void tSB_Thoat_Click(object sender, EventArgs e)
        {
            tSB_Them.Enabled = true;
            tSB_Sua.Enabled = true;
            tSB_Xoa.Enabled = true;
            tSB_Capnhat.Enabled = true;
            tSB_Luu.Enabled = false;
            tSB_Thoat.Enabled = false;
            txtMaSV.Enabled = true;
            tool = "";
            Reset();
        }

        private void tSB_Capnhat_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView.Rows.Clear();
            dsSV.Clear();
            GetAllStudent("");
        }

        private void tSB_Xoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            string s = txtMaSV.Text;
            if (s == "") return;
            else
            {
                DialogResult h = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + s + " không?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    DeleteAStudent();
                    Reset();
                    dataGridView.Rows.Clear();
                    dsSV.Clear();
                    GetAllStudent("");
                    MessageBox.Show("Đã xóa sinh viên!", "Thông Báo");
                }
            }

        }
 
       private void lstView_MouseClick(object sender, MouseEventArgs e)
        {
           // ListView lstView = sender as ListView;
            ListViewItem item=new ListViewItem();
       //     item.Selected.ToString();
       //     string id = item.SubItems[0].Name;
            // Query theo maSV lay duoc

          //  MessageBox.Show();
            //MessageBox.Show("s");
            // Hittestinfo of the clicked ListView location
            ListViewHitTestInfo listViewHitTestInfo = lstView.HitTest(e.X, e.Y);

            // Index of the clicked ListView column
            int columnIndex = listViewHitTestInfo.Item.SubItems.IndexOf(listViewHitTestInfo.SubItem);
            MessageBox.Show(columnIndex.ToString());
        }
    }
}
