using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    public class SinhVien
    {
        //STT, Ho Ten, Nam Sinh, gioi tinh, Que Quan, Diem TB, Yeu?
        private string stt;

        public string Stt
        {
            get { return stt; }
            set { stt = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string namSinh;

        public string NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        private string queQuan;

        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }
        private string diemTB;

        public string DiemTB
        {
            get { return diemTB; }
            set { diemTB = value; }
        }
        private bool gioiTinh;

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private bool yeu;

        public bool Yeu
        {
            get { return yeu; }
            set { yeu = value; }
        }
         //STT, Ho Ten, Nam Sinh, gioi tinh, Que Quan, Diem TB, Yeu?
        public SinhVien(string Stt, string HoTen, string NamSinh, bool GioiTinh, string QueQuan, string DiemTB, bool Yeu)
        {
            stt = Stt;
            hoTen = HoTen;
            gioiTinh = GioiTinh;
            queQuan = QueQuan;
            diemTB = DiemTB;
            yeu = Yeu;
            namSinh = NamSinh;
        }
        public SinhVien()
        { }
        
    }
}
