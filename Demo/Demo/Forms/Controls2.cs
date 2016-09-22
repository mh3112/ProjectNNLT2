using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Classes;
namespace Demo.Forms
{
    public partial class Controls2 : Form
    {
        List<SinhVien> dsSV = new List<SinhVien>();
        string m_chucnang = "";

        public Controls2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Controls2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            GetAllStudent("");
        }

       
        public void GetAllStudent(string path)
        {
            StreamReader reader = null;  // Nhớ thêm using System.IO;
            reader = File.OpenText("SV.txt");
            string str;
            while ((str = reader.ReadLine()) != null)
            {
                string[] st = str.Split('\t');
                // Ngăn cách nhau bởi dấu tab
                bool gioitinh=false;
                bool yeu= false;
                if (st[3] == "True")
                    gioitinh = true;

                else
                    gioitinh = false;
                if (st[6] == "True")
                    yeu = true;
                else
                    yeu = false;
               
                SinhVien sv = new SinhVien(st[0], st[1],st[2], gioitinh , st[4], st[5],  yeu);
                // Đưa sinh viên này vào danh sách
                dsSV.Add(sv);

            }
            reader.Close();

            foreach (SinhVien sv in dsSV)
            {
                dataGridView1.Rows.Add(sv.Stt, sv.HoTen, sv.NamSinh, sv.GioiTinh, sv.QueQuan, sv.DiemTB, sv.Yeu);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells["stt"].Value != null)
                {
                    // lấy id của dòng đang chọn
                    // truy cập vào từng cell gía trị
                    txtSTT.Text = dataGridView1.CurrentRow.Cells["stt"].Value.ToString();
                    txtHoten.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
                    txtNamSinh.Text = dataGridView1.CurrentRow.Cells["namsinh"].Value.ToString();
                    bool gioiTinh = (bool)dataGridView1.CurrentRow.Cells["gioitinh"].Value;
                    if (gioiTinh)
                        rdbNam.Checked = true;
                    else
                        rdbNu.Checked = true;

                    txtQueQuan.Text = dataGridView1.CurrentRow.Cells["quequan"].Value.ToString();
                    txtTB.Text = dataGridView1.CurrentRow.Cells["diemTB"].Value.ToString();
                    bool dayeu = (bool)dataGridView1.CurrentRow.Cells["yeu"].Value;
                    if (dayeu)
                        chkYeu.Checked = true;
                    else
                        chkYeu.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void insertAStudent(SinhVien newSv)
        {
            // Hàm ghi ra file text viết ở đây
            StreamWriter write = new StreamWriter("SV.txt", false);
            //4	Hoang Anh	1985	0	Bac Ninh	3.0	1
            string s = newSv.Stt + "\t" + newSv.HoTen + "\t" + newSv.NamSinh + "\t" + newSv.GioiTinh + "\t" + newSv.QueQuan + "\t" + newSv.DiemTB + "\t" + newSv.Yeu;
            write.WriteLine(s);
            write.Close();
        }

        public void Resest()
        {
            txtSTT.Clear();
            txtTB.Clear();
            txtQueQuan.Clear();
            txtNamSinh.Clear();
            txtHoten.Clear();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (m_chucnang == "them")
            {
                // Bước 1: Lấy thông tin người dùng mới nhập vào và gán cho newSV
                string stt = txtSTT.Text;
                string diemTB = txtTB.Text;
                string queQuan = txtQueQuan.Text;
                string namSinh = txtNamSinh.Text;
                string hoTen = txtHoten.Text;
                bool gioiTinh = rdbNam.Checked ? true : false;
                bool daYeu = chkYeu.Checked ? true : false;

                SinhVien newSv = new SinhVien(stt, hoTen, namSinh, gioiTinh, queQuan, diemTB, daYeu);
                // Bước 2: Thêm newSv này vào file csdl SV.txt
                //insertAStudent(newSv);
                // Hàm ghi ra file text viết ở đây
                StreamWriter write = new StreamWriter("SV.txt", true);
                //4	Hoang Anh	1985	0	Bac Ninh	3.0	1
                string s = newSv.Stt + "\t" + newSv.HoTen + "\t" + newSv.NamSinh + "\t" + newSv.GioiTinh + "\t" + newSv.QueQuan + "\t" + newSv.DiemTB + "\t" + newSv.Yeu;
                write.WriteLine(s);
                write.Close();
                //MessageBox.Show("Xong");
                // Load lại dataGridview
                // Xóa những dữ liệu cũ đi
                dataGridView1.Rows.Clear();
                // Và hiển thị lại dữ liệu mới
                dsSV.Clear();
                GetAllStudent("");
            }
            else
            {
                MessageBox.Show("Chức năng này chỉ sử dụng khi Thêm mới");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            m_chucnang = "them";
            // Xóa trắng các textbox
            Resest();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (txtSTT.Text == "") return;

            foreach (SinhVien sv in dsSV)
            {
                if (sv.Stt == txtSTT.Text)
                {
                    dsSV.Remove(sv);
                    return;
                }
            }
        }


        public void WriteToFile(List<SinhVien> list, FileStream fs)
        {
            StreamWriter write = new StreamWriter(fs, System.Text.Encoding.UTF8);
           // StreamWriter write = new StreamWriter("SV.txt",true);
            foreach (SinhVien newSv in list)
            {
                //insertAStudent(sv);
                string s = newSv.Stt + "\t" + newSv.HoTen + "\t" + newSv.NamSinh + "\t" + newSv.GioiTinh + "\t" + newSv.QueQuan + "\t" + newSv.DiemTB + "\t" + newSv.Yeu;
                write.WriteLine(s);
            }
            write.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                m_chucnang = "sua";
                #region ""
                if (txtSTT.Text == "") return;

                foreach (SinhVien sv in dsSV)
                {
                    if (sv.Stt == txtSTT.Text)
                    {
                        // Tạo mới và đưa Sinh viên mới vào danh sách
                        SinhVien sinhvien = new SinhVien();
                        sinhvien.Stt = txtSTT.Text;
                        sinhvien.HoTen = txtHoten.Text;
                        sinhvien.NamSinh = txtNamSinh.Text;
                        sinhvien.QueQuan = txtQueQuan.Text;
                        sinhvien.DiemTB = txtTB.Text;
                        sinhvien.GioiTinh = rdbNam.Checked ? true : false;
                        sinhvien.Yeu = chkYeu.Checked ? true : false;
                        dsSV.Insert(int.Parse(txtSTT.Text), sinhvien);
                        // Xóa sinh viên cũ đi
                        dsSV.Remove(sv);

                        break;
                    }
                }
                #endregion
                // Sau khi có được danh sách sinh viên mới rồi, ta cần
                // Xóa file dữ liệu cũ và ghi dữ liệu mới vào lại file đó
                if (File.Exists("SV.txt"))
                    File.Delete("SV.txt");
                FileStream fs = new FileStream("SV.txt", FileMode.CreateNew);
                WriteToFile(dsSV, fs);

                // Xóa dữ liệu hiển thị cũ đi
                dataGridView1.Rows.Clear();
                dsSV.Clear();

                // Ghi và hiển thị dữ liệu mới
                GetAllStudent("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}